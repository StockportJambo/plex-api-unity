using Newtonsoft.Json;
using Plex.Api.Helpers;

namespace Plex.Api.Models
{
    public class MediaRole
    {
        //[JsonConverter(typeof(IntValueConverter))]
        public int Id { get; set; }
        public string Filter { get; set; }
        public string Role { get; set; }
        public string Thumb { get; set; }
        public string Tag { get; set; }
    }
}