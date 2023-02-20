using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class Clouds
    {
        public Clouds(
            int? all
        )
        {
            this.all = all;
        }

        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("all")]
        public int? all { get; }
    }
}
