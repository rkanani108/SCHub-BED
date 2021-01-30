using Newtonsoft.Json;
using Squidex.ClientLibrary;
using System.Collections.Generic;

namespace Web.Services.Model
{
    public sealed class MediaData
    {
        // Squidex delivers hash maps for each field, but the
        // InvariantConverter helps to simplify the model.
        [JsonConverter(typeof(InvariantConverter))]
        public string Title { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Orator { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public List<string> MediaType { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public List<string> RelatedContent { get; set; }

        // For localizable fields you can use dictionaries.
        //public Dictionary<string, string> Text { get; set; }
    }

    public sealed class Media : Content<MediaData>
    {
    }
}