using Newtonsoft.Json;

namespace Plex.Api.Models
{
    public class Directory
    {
        [JsonProperty("allowSync")]
        public bool AllowSync { get; set; }
        
        [JsonProperty("art")]
        public string Art { get; set; }
        
        [JsonProperty("composite")]
        public string Composite { get; set; }
        
        [JsonProperty("filters")]
        public bool Filters { get; set; }
        
        [JsonProperty("refreshing")]
        public bool Refreshing { get; set; }
        
        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
        
        [JsonProperty("type")] 
        public string Type { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("agent")]
        public string Agent { get; set; }
        
        [JsonProperty("scanner")]
        public string Scanner { get; set; }
        
        [JsonProperty("language")]
        public string Language { get; set; }
        
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
        
        [JsonProperty("updatedAt")]
        public int UpdatedAt { get; set; }

        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }
        
        [JsonProperty("scannedAt")]
        public int ScannedAt { get; set; }
        
        [JsonProperty("content")]
        public bool Content { get; set; }
        
        [JsonProperty("directory")]
        public bool IsDirectory { get; set; }
        
        [JsonProperty("contentChangedAt")]
        public int ContentChangedAt { get; set; }
      
        
        [JsonProperty("Location")]
        public Location[] Location { get; set; }
    }
}