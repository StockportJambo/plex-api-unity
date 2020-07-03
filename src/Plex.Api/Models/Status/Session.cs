using System.Collections.Generic;
using Newtonsoft.Json;
using Plex.Api.Helpers;

namespace Plex.Api.Models.Status
{
    public class SessionWrapper
    {
        [JsonProperty("MediaContainer")]
        public SessionContainer SessionContainer { get; set; }
    }

    public class SessionContainer
    {
        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("Metadata")]
        public List<Session> Sessions { get; set; }
    }

    public class Session
    {
        [JsonProperty("addedAt")]
        public string AddedAt { get; set; }

        [JsonProperty("art")]
        public string Art { get; set; }

        [JsonProperty("contentRating")]
        public string ContentRating { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("grandparentArt")]
        public string GrandparentArt { get; set; }

        [JsonProperty("grandparentGuid")]
        public string GrandparentGuid { get; set; }

        [JsonProperty("grandparentKey")]
        public string GrandparentKey { get; set; }

        [JsonProperty("grandparentRatingKey")]
        public string GrandparentRatingKey { get; set; }

        [JsonProperty("grandparentTheme")]
        public string GrandparentTheme { get; set; }

        [JsonProperty("grandparentThumb")]
        public string GrandparentThumb { get; set; }

        [JsonProperty("grandparentTitle")]
        public string GrandparentTitle { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("lastViewedAt")]
        public string LastViewedAt { get; set; }

        [JsonProperty("librarySectionID")]
        public string LibrarySectionId { get; set; }

        [JsonProperty("librarySectionKey")]
        public string LibrarySectionKey { get; set; }

        [JsonProperty("librarySectionTitle")]
        public string LibrarySectionTitle { get; set; }

        [JsonProperty("originallyAvailableAt")]
        public string OriginallyAvailableAt { get; set; }

        [JsonProperty("parentGuid")]
        public string ParentGuid { get; set; }

        [JsonProperty("parentIndex")]
        public string ParentIndex { get; set; }

        [JsonProperty("parentKey")]
        public string ParentKey { get; set; }

        [JsonProperty("parentRatingKey")]
        public string ParentRatingKey { get; set; }

        [JsonProperty("parentThumb")]
        public string ParentThumb { get; set; }

        [JsonProperty("parentTitle")]
        public string ParentTitle { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("ratingKey")]
        public string RatingKey { get; set; }

        [JsonProperty("sessionKey")]
        public string SessionKey { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("viewOffset")]
        public string ViewOffset { get; set; }

        [JsonProperty("year")]
        //[JsonConverter(typeof(IntValueConverter))]
        public int Year { get; set; }
        
        [JsonProperty("Director")]
        public List<Director> Directors { get; set; }

        [JsonProperty("Writer")]
        public List<Writer> Writers { get; set; }

        [JsonProperty("Media")]
        public List<Medium> Media { get; set; }

        [JsonProperty("User")]
        public User User { get; set; }

        [JsonProperty("Player")]
        public Player Player { get; set; }

        [JsonProperty("Session")]
        public SessionDetail SessionDetail { get; set; }

        [JsonProperty("TranscodeSession")]
        public TranscodeSession TranscodeSession { get; set; }
    }
   
    public class Player
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("machineIdentifier")]
        public string MachineIdentifier { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("platformVersion")]
        public string PlatformVersion { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("remotePublicAddress")]
        public string RemotePublicAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("local")]
        public bool Local { get; set; }

        [JsonProperty("relayed")]
        public bool Relayed { get; set; }

        [JsonProperty("secure")]
        public bool Secure { get; set; }

        [JsonProperty("userID")]
        public long UserId { get; set; }
    }

    public class SessionDetail
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("bandwidth")]
        public long Bandwidth { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class TranscodeSession
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("throttled")]
        public bool Throttled { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        //[JsonConverter(typeof(DoubleValueConverter))]
        [JsonProperty("progress")]
        public double Progress { get; set; }

        //[JsonConverter(typeof(DoubleValueConverter))]
        [JsonProperty("speed")]
        public double Speed { get; set; }

        //[JsonConverter(typeof(LongValueConverter))]
        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("sourceVideoCodec")]
        public string SourceVideoCodec { get; set; }

        [JsonProperty("sourceAudioCodec")]
        public string SourceAudioCodec { get; set; }

        [JsonProperty("videoDecision")]
        public string VideoDecision { get; set; }

        [JsonProperty("audioDecision")]
        public string AudioDecision { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("container")]
        public string Container { get; set; }

        [JsonProperty("videoCodec")]
        public string VideoCodec { get; set; }

        [JsonProperty("audioCodec")]
        public string AudioCodec { get; set; }

        [JsonProperty("audioChannels")]
        public long AudioChannels { get; set; }

        [JsonProperty("transcodeHwRequested")]
        public bool TranscodeHwRequested { get; set; }

        [JsonProperty("transcodeHwFullPipeline")]
        public bool TranscodeHwFullPipeline { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("maxOffsetAvailable")]
        public string MaxOffsetAvailable { get; set; }

        [JsonProperty("minOffsetAvailable")]
        public string MinOffsetAvailable { get; set; }
    }
}