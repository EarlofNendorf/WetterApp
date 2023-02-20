using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class Coord
    {
        public Coord(
            double? lat,
            double? lon
        )
        {
            this.lat = lat;
            this.lon = lon;
        }

        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("lat")]
        public double? lat { get; }

        [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("lon")]
        public double? lon { get; }
    }
}
