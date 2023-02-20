using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class List
    {
        public List(
            int? dt,
            Main main,
            List<Weather> weather,
            Clouds clouds,
            Wind wind,
            int? visibility,
            double? pop,
            Rain rain,
            Sys sys,
            string dt_txt
        )
        {
            this.dt = dt;
            this.main = main;
            this.weather = weather;
            this.clouds = clouds;
            this.wind = wind;
            this.visibility = visibility;
            this.pop = pop;
            this.rain = rain;
            this.sys = sys;
            this.dt_txt = dt_txt;
        }

        [JsonProperty("dt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("dt")]
        public int? dt { get; }

        [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("main")]
        public Main main { get; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("weather")]
        public IReadOnlyList<Weather> weather { get; }

        [JsonProperty("clouds", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("clouds")]
        public Clouds clouds { get; }

        [JsonProperty("wind", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("wind")]
        public Wind wind { get; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("visibility")]
        public int? visibility { get; }

        [JsonProperty("pop", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("pop")]
        public double? pop { get; }

        [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("rain")]
        public Rain rain { get; }

        [JsonProperty("sys", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("sys")]
        public Sys sys { get; }

        [JsonProperty("dt_txt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("dt_txt")]
        public string dt_txt { get; }
    }
}
