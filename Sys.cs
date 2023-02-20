using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class Sys
    {
        public Sys(
            string pod
        )
        {
            this.pod = pod;
        }

        [JsonProperty("pod", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("pod")]
        public string pod { get; }
    }
}
