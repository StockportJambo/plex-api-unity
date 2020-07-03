using System.Collections.Generic;
using Newtonsoft.Json;

namespace Plex.Api.Models
{
    public class UserRole
    {
        [JsonProperty("Roles")]
        public List<string> Roles { get; set; }
    }
}