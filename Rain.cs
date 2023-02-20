using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterAppDL
{
    public class Rain
    {
        public Rain(
            double? _3h
        )
        {
            this._3h = _3h;
        }

        [JsonProperty("3h", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("3h")]
        public double? _3h { get; }
    }
}
