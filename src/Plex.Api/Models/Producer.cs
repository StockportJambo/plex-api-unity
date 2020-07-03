using Newtonsoft.Json;
using Plex.Api.Helpers;

namespace Plex.Api.Models
{
    public class Producer
    {
        //[JsonConverter(typeof(IntValueConverter))]
        public int Id { get; set; }

        public string Filter { get; set; }
        public string Tag { get; set; }
    }
}