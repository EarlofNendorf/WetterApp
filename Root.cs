using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class Root
    {
        public Root(
            string cod,
            int? message,
            int? cnt,
            List<List> list,
            City city
        )
        {
            this.cod = cod;
            this.message = message;
            this.cnt = cnt;
            this.list = list;
            this.city = city;
        }

        [JsonProperty("cod", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("cod")]
        public string cod { get; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("message")]
        public int? message { get; }

        [JsonProperty("cnt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("cnt")]
        public int? cnt { get; }

        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("list")]
        public IReadOnlyList<List> list { get; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("city")]
        public City city { get; }
    }
}
