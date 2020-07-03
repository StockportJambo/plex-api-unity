using Newtonsoft.Json;

namespace Plex.Api.Models
{
    public class Subscription
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        
        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("plan")]
        public object Plan { get; set; }
        
        [JsonProperty("features")]
        public object Features { get; set; }
    }
}