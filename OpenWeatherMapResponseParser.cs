namespace WetterAppDL
{
    internal class OpenWeatherMapResponseParser
    {
        internal string parseBeschreibung(Root result)
        {
            return result.list.FirstOrDefault().weather.FirstOrDefault().description.ToString();
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

    }
}
