using Newtonsoft.Json;
using System.Collections.Generic;

namespace Web.Services.Model
{
    public class PageLinkFlatData
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PageLink
    {
        [JsonProperty("flatData")]
        public PageLinkFlatData FlatData { get; set; }
    }

    public class Logo
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class HeaderFlatData
    {
        [JsonProperty("pageLinks")]
        public IList<PageLink> PageLinks { get; set; }

        [JsonProperty("logo")]
        public IList<Logo> Logo { get; set; }
    }

    public class QueryHeaderContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("flatData")]
        public HeaderFlatData FlatData { get; set; }
    }

    public class Result
    {
        [JsonProperty("queryHeaderContents")]
        public IList<QueryHeaderContent> QueryHeaderContents { get; set; }
    }
}