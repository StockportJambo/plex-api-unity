using Newtonsoft.Json;
using Plex.Api.Helpers;

namespace Plex.Api.Models
{
    /// <summary>
    /// Director Plex Object
    /// </summary>
    public class Director
    { 
        [JsonProperty("id")]
        //[JsonConverter(typeof(IntValueConverter))]
        public int Id { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }
        
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}