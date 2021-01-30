using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;

namespace Web.Services.Model
{
    public partial class FooterResult
    {
        [JsonProperty("queryFooterContents")]
        public QueryFooterContent[] QueryFooterContents { get; set; }
    }

    public partial class QueryFooterContent
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("flatData")]
        public QueryFooterContentFlatData FlatData { get; set; }
    }

    public partial class QueryFooterContentFlatData
    {
        [JsonProperty("aboutHeading")]
        public string AboutHeading { get; set; }

        [JsonProperty("aboutDescription")]
        public string AboutDescription { get; set; }

        [JsonProperty("photoHeading")]
        public string PhotoHeading { get; set; }

        [JsonProperty("photoImageLinks")]
        public PhotoImageLink[] PhotoImageLinks { get; set; }

        [JsonProperty("usefulLinkHeading")]
        public string UsefulLinkHeading { get; set; }

        [JsonProperty("usefulPageLinks")]
        public UsefulPageLink[] UsefulPageLinks { get; set; }

        [JsonProperty("contactHeading")]
        public string ContactHeading { get; set; }

        [JsonProperty("address")]
        public MarkupString Address { get; set; }

        [JsonProperty("mobile")]
        public MarkupString Mobile { get; set; }

        [JsonProperty("emailWebsite")]
        public MarkupString EmailWebsite { get; set; }

        [JsonProperty("copyrightText")]
        public string CopyrightText { get; set; }

        [JsonProperty("socialLinks")]
        public SocialLink[] SocialLinks { get; set; }
    }

    public partial class PhotoImageLink
    {
        [JsonProperty("flatData")]
        public PhotoImageLinkFlatData FlatData { get; set; }
    }

    public partial class PhotoImageLinkFlatData
    {
        [JsonProperty("image")]
        public ThumbImage[] Image { get; set; }
    }

    public partial class ThumbImage
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class SocialLink
    {
        [JsonProperty("flatData")]
        public SocialLinkFlatData FlatData { get; set; }
    }

    public partial class SocialLinkFlatData
    {
        [JsonProperty("socialTitle")]
        public string SocialTitle { get; set; }

        [JsonProperty("socialUrl")]
        public Uri SocialUrl { get; set; }

        [JsonProperty("socialIconLinks")]
        public SocialIconLink[] SocialIconLinks { get; set; }
    }

    public partial class SocialIconLink
    {
        [JsonProperty("flatData")]
        public SocialIconLinkFlatData FlatData { get; set; }
    }

    public partial class SocialIconLinkFlatData
    {
        [JsonProperty("socialClass")]
        public string SocialClass { get; set; }
    }

    public partial class UsefulPageLink
    {
        [JsonProperty("flatData")]
        public UsefulPageLinkFlatData FlatData { get; set; }
    }

    public partial class UsefulPageLinkFlatData
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}