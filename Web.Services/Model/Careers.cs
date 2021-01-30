using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Web.Services.Model.Careers
{
    public partial class QueryCareersContentResult
    {
        [JsonProperty("queryCareersContents", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryCareersContent> QueryCareersContents { get; set; }
    }

    public partial class QueryCareersContent
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public QueryCareersContentFlatData FlatData { get; set; }
    }

    public partial class QueryCareersContentFlatData
    {
        [JsonProperty("heroHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroHeading { get; set; }

        [JsonProperty("heroDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroDescription { get; set; }

        [JsonProperty("heroCtaText", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroCtaText { get; set; }

        [JsonProperty("heroCtaLink", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroCtaLink { get; set; }

        [JsonProperty("heroImage", NullValueHandling = NullValueHandling.Ignore)]
        public List<Image> HeroImage { get; set; }

        [JsonProperty("hiringTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string HiringTitle { get; set; }

        [JsonProperty("hiringHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string HiringHeading { get; set; }

        [JsonProperty("hiringDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string HiringDescription { get; set; }

        [JsonProperty("hiringPersonImage", NullValueHandling = NullValueHandling.Ignore)]
        public List<Image> HiringPersonImage { get; set; }

        [JsonProperty("hiringPersonQuota", NullValueHandling = NullValueHandling.Ignore)]
        public string HiringPersonQuota { get; set; }

        [JsonProperty("hiringPersonName", NullValueHandling = NullValueHandling.Ignore)]
        public string HiringPersonName { get; set; }

        [JsonProperty("hiringBackgroundImage", NullValueHandling = NullValueHandling.Ignore)]
        public List<Image> HiringBackgroundImage { get; set; }

        [JsonProperty("hiringStatement", NullValueHandling = NullValueHandling.Ignore)]
        public string HiringStatement { get; set; }

        [JsonProperty("ctaBlockLink", NullValueHandling = NullValueHandling.Ignore)]
        public List<CtaBlockLink> CtaBlockLink { get; set; }
    }

    public partial class CtaBlockLink
    {
        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public CtaBlockLinkFlatData FlatData { get; set; }
    }

    public partial class CtaBlockLinkFlatData
    {
        [JsonProperty("ctaHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string CtaHeading { get; set; }

        [JsonProperty("ctaDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string CtaDescription { get; set; }

        [JsonProperty("ctaEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string CtaEmail { get; set; }

        [JsonProperty("ctaMobileNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CtaMobileNumber { get; set; }

        [JsonProperty("ctaButtonText1", NullValueHandling = NullValueHandling.Ignore)]
        public string CtaButtonText1 { get; set; }

        [JsonProperty("ctaButtonLink1", NullValueHandling = NullValueHandling.Ignore)]
        public string CtaButtonLink1 { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }
}