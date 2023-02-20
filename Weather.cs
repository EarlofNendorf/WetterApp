using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class Weather
    {
        public Weather(
            int? id,
            string main,
            string description,
            string icon
        )
        {
            this.id = id;
            this.main = main;
            this.description = description;
            this.icon = icon;
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int? id { get; }

        [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("main")]
        public string main { get; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("description")]
        public string description { get; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("icon")]
        public string icon { get; }
    }
}
