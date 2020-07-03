using Newtonsoft.Json;

namespace Plex.Api.Models
{
    public class PlexMediaContainer
    {
        [JsonProperty("MediaContainer")]
        public MediaContainer MediaContainer { get; set; }
    }
}