using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class Wind
    {
        public Wind(
            double? speed,
            int? deg,
            double? gust
        )
        {
            this.speed = speed;
            this.deg = deg;
            this.gust = gust;
        }

        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("speed")]
        public double? speed { get; }

        [JsonProperty("deg", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("deg")]
        public int? deg { get; }

        [JsonProperty("gust", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("gust")]
        public double? gust { get; }
    }
}
