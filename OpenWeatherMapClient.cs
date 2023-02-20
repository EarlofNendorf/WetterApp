using Newtonsoft.Json;

namespace WetterAppDL
{
    internal class OpenWeatherMapClient
    {
        private readonly string weatherAPIKey;
        private OpenWeatherMapResponseParser parser;

        public OpenWeatherMapClient(string weatherAPIKey, OpenWeatherMapResponseParser parser)
        {
            this.weatherAPIKey = weatherAPIKey;
            this.parser = parser;
        }

        // internal async Task<WetterBeschreibung> GetWetterResponseAsync(string stadt, HttpClient httpClient)
        internal async Task GetWetterResponseAsync(string stadt, HttpClient httpClient)
        {
            /*Beispiel Web-API Forecast Wetterdaten
             *https://api.openweathermap.org/data/2.5/forecast?q=Stolzenau,DE&units=metric&appid=abcdefghijklmnopqrstuvwxyz
             */

            var u = "https://api.openweathermap.org/data/2.5/forecast";
            var builder = new UriBuilder(u);
            builder.Query = "q=" + stadt + ",DE&units=metric&lang=de&" + "appid=" + weatherAPIKey;
            var url = builder.ToString();

            //WetterBeschreibung beschreibung = new WetterBeschreibung();

            using var client = new HttpClient();
            {
                try
                {
                    //Ist die Url überhaupt ansprechbar?
                    using HttpResponseMessage response = await httpClient.GetAsync(url);
                    //Console.WriteLine(response.EnsureSuccessStatusCode());

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        //Console.WriteLine($"{jsonResponse}\n");
                        if (!string.IsNullOrEmpty(jsonResponse))
                        {
                            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonResponse);

                            //Die Stadt liefert auch sauber Daten = > 200 OK
                            if (myDeserializedClass.cod == "200")
                            {
                                for (int i = 0; i < myDeserializedClass.list.Count; i++)
                                {
                                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 60)));
                                    Console.WriteLine($"Wettervorhersage für die nächsten Tage in: {stadt} ");
                                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 60)));
                                    Console.WriteLine("Wettermessung vom    " + myDeserializedClass.list[i].dt_txt);
                                    Console.WriteLine("Wetter:  " + myDeserializedClass.list[i].weather[0].description);
                                    Console.WriteLine("Temperatur:  " + myDeserializedClass.list[i].main.temp);
                                    Console.WriteLine("Gefühlte Temperatur:  " + myDeserializedClass.list[i].main.feels_like);
                                    Console.WriteLine("Min Temperatur:  " + myDeserializedClass.list[i].main.temp_min);
                                    Console.WriteLine("Max Temperatur:  " + myDeserializedClass.list[i].main.temp_max);
                                    Console.WriteLine("Bewölkung:  " + myDeserializedClass.list[i].main.humidity);
                                    Console.WriteLine("hPa:  " + myDeserializedClass.list[i].main.pressure);
                                    //Console.WriteLine("Regenmenge in mm letzten 3 Std: " + myDeserializedClass.list[i].rain);

                                    if (myDeserializedClass.list[i].Equals("rain"))
                                    {
                                        Console.WriteLine("Regenmenge in mm letzten 3 Std: " + myDeserializedClass.list[i].rain);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Regenmenge: null mm in den  letzten 3 Std: ");
                                    }

                                    Console.WriteLine("Windgeschwindigkeit:  " + myDeserializedClass.list[i].wind.speed);
                                    //Console.WriteLine(string.Concat(Enumerable.Repeat("=", 50)));
                                }



                                // beschreibung.setBeschreibung(parser.parseBeschreibung(myDeserializedClass));
                                // beschreibung.setTemperatur(parser.parseTemeratur(myDeserializedClass));
                                // beschreibung.setMinTemperatur(parser.parseMinTemperatur(myDeserializedClass));
                                // beschreibung.setMaxTemperatur(parser.parseMaxTemperatur(myDeserializedClass));
                                // beschreibung.setWindGeschwindigkeit(parser.parseWindgeschwindigkeit(myDeserializedClass));
                                // beschreibung.setLuftfeuchtigkeit(parser.parseLuftfeuchtigkeit(myDeserializedClass));
                                // beschreibung.setBewoelkung(parser.parseBewoelkung(myDeserializedClass));
                                // beschreibung.setRegenInMMLLetzten3Stunden(parser.parseRegenmenge(myDeserializedClass));
                                // beschreibung.setDatum(parser.parseDt(myDeserializedClass));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //return beschreibung;
        }
    }
}