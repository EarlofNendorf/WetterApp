using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class Main
    {
        public Main(
            double? temp,
            double? feels_like,
            double? temp_min,
            double? temp_max,
            int? pressure,
            int? sea_level,
            int? grnd_level,
            int? humidity,
            double? temp_kf
        )
        {
            this.temp = temp;
            this.feels_like = feels_like;
            this.temp_min = temp_min;
            this.temp_max = temp_max;
            this.pressure = pressure;
            this.sea_level = sea_level;
            this.grnd_level = grnd_level;
            this.humidity = humidity;
            this.temp_kf = temp_kf;
        }

        [JsonProperty("temp", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("temp")]
        public double? temp { get; }

        [JsonProperty("feels_like", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("feels_like")]
        public double? feels_like { get; }

        [JsonProperty("temp_min", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("temp_min")]
        public double? temp_min { get; }

        [JsonProperty("temp_max", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("temp_max")]
        public double? temp_max { get; }

        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("pressure")]
        public int? pressure { get; }

        [JsonProperty("sea_level", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("sea_level")]
        public int? sea_level { get; }

        [JsonProperty("grnd_level", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("grnd_level")]
        public int? grnd_level { get; }

        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("humidity")]
        public int? humidity { get; }

        [JsonProperty("temp_kf", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("temp_kf")]
        public double? temp_kf { get; }
    }
}
