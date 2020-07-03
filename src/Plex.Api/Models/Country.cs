using Newtonsoft.Json;
using Plex.Api.Helpers;

namespace Plex.Api.Models
{
    public class Country
    {
        [JsonProperty("id")]
        //[JsonConverter(typeof(IntValueConverter))]
        public int Id { get; set; }
        
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}