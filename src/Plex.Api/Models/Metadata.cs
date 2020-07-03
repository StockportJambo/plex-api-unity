using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Plex.Api.Helpers;

namespace Plex.Api.Models
{
    public class Metadata
    {
        //Movie
        public string RatingKey { get; set; }
        public string Key { get; set; }
        public string LibrarySectionTitle { get; set; }
        [JsonProperty("librarySectionID")] 
        public int LibrarySectionId { get; set; }
        public string LibrarySectionKey { get; set; }
        public string Studio { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string ContentRating { get; set; }
        public string Summary { get; set; }
        public float Rating { get; set; }
        public int ViewCount { get; set; }
        public int LastViewedAt { get; set; }
        public int Year { get; set; }
        public string TagLine { get; set; }
        public string Thumb { get; set; }
        public string Art { get; set; }
        public int Duration { get; set; }
        public string OriginallyAvailableAt { get; set; }
        public int AddedAt { get; set; }
        public int UpdatedAt { get; set; }
        public string ChapterSource { get; set; }
        public string RatingImage { get; set; }
        public string ExternalProvider { get; set; }
        public string ExternalProviderId { get; set; }
        
        [JsonIgnore]
        public string Guid { get; set; }
        [JsonProperty("guid")]
        public string ExternalProviderInfo
        {
            set
            {
                var match = Regex.Match(value, @"\.(?<provider>[a-z]+)://(?<id>[^\?]+)");
                Guid = value;
                ExternalProvider = match.Groups["provider"].Value;
                ExternalProviderId = match.Groups["id"].Value;
            }
        }

        [JsonProperty("Media")] public List<Medium> Media { get; set; }

        [JsonProperty("Genre")] public Genre[] Genres { get; set; }

        [JsonProperty("Director")] public Director[] Directors { get; set; }

        [JsonProperty("Writer")] public Writer[] Writers { get; set; }

        [JsonProperty("Producer")] public List<Producer> Producer { get; set; }

        [JsonProperty("Country")] public Country[] Countries { get; set; }

        [JsonProperty("Role")] public List<MediaRole> Roles { get; set; }

        [JsonProperty("Similar")] public List<Similar> Similar { get; set; }

        [JsonProperty("Field")] public List<Field> Field { get; set; }


        //Library Sections
        public string TitleSort { get; set; }
        public int Index { get; set; }
        public string Banner { get; set; }
        public int LeafCount { get; set; }
        public int ViewedLeafCount { get; set; }

        //[JsonConverter(typeof(IntValueConverter))]
        public int ChildCount { get; set; }

        public string Theme { get; set; }


        //TV Show Seasons
        public string ParentRatingKey { get; set; }
        public string ParentKey { get; set; }
        public string ParentTitle { get; set; }
        public int ParentIndex { get; set; }
        public string ParentThumb { get; set; }
        public string ParentTheme { get; set; }


        //TV Show Episode
        public string GrandparentRatingKey { get; set; }
        public string GrandparentKey { get; set; }
        public string GrandparentTitle { get; set; }
        public string GrandparentThumb { get; set; }
        public string GrandparentArt { get; set; }
        public string GrandparentTheme { get; set; }


        //Movie Section
        public string PrimaryExtraKey { get; set; }
        [JsonProperty("Collection")] public List<Collection> Collection { get; set; }
        public string OriginalTitle { get; set; }
        public int? ViewOffset { get; set; }
    }
}