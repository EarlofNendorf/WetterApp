using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WetterAppDL
{
    public class City
    {
        public City(
            int? id,
            string name,
            Coord coord,
            string country,
            int? population,
            int? timezone,
            int? sunrise,
            int? sunset
        )
        {
            this.id = id;
            this.name = name;
            this.coord = coord;
            this.country = country;
            this.population = population;
            this.timezone = timezone;
            this.sunrise = sunrise;
            this.sunset = sunset;
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int? id { get; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string name { get; }

        [JsonProperty("coord", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("coord")]
        public Coord coord { get; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("country")]
        public string country { get; }

        [JsonProperty("population", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("population")]
        public int? population { get; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("timezone")]
        public int? timezone { get; }

        [JsonProperty("sunrise", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("sunrise")]
        public int? sunrise { get; }

        [JsonProperty("sunset", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("sunset")]
        public int? sunset { get; }
    }
}
