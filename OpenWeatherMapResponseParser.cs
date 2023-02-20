namespace WetterAppDL
{
    internal class OpenWeatherMapResponseParser
    {
        internal string parseBeschreibung(string result)
        {
            return result;
            //return result.list.FirstOrDefault().weather.FirstOrDefault().description.ToString();
        }

        internal string parseMinTemperatur(Root result)
        {
            return result.list.FirstOrDefault().main.temp_min.ToString();
        }

        internal string parseMaxTemperatur(Root result)
        {
            return result.list.FirstOrDefault().main.temp_max.ToString();
        }

        internal string parseTemeratur(Root result)
        {
            return result.list.FirstOrDefault().main.temp.ToString();
        }

        internal string parseWindgeschwindigkeit(Root result)
        {
            return result.list.FirstOrDefault().wind.speed.ToString();
        }

        internal string parseLuftfeuchtigkeit(Root result)
        {
            return result.list.FirstOrDefault().main.humidity.ToString();
        }
        internal string parseBewoelkung(Root result)
        {
            return result.list.FirstOrDefault().clouds.all.ToString();
        }

        internal string parseRegenmenge(Root result)
        {
            return result.list.FirstOrDefault().rain._3h.ToString();
        }

        internal string parseDt(string result)
        {
            return result;
            //return string.Empty;


            // //beispiel-Zeit "dt": 1646318698,
            // var epoch = result.list.FirstOrDefault().dt;
            // if (epoch > 1)
            // {
            //     //return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds((double)epoch).ToShortDateString();
            //     //GMT + 01:00 Europe/Berlin (CET)
            //     return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds((double)epoch).AddHours(1).ToShortDateString()  + " " +
            //            new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds((double)epoch).AddHours(1).ToLongTimeString() + " Uhr";
            // }
            // else
            // {
            //     return string.Empty;
            // }
        }
    }
}
