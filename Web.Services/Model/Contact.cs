using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Web.Services.Model.Contact
{
    public partial class QueryContactContentResult
    {
        [JsonProperty("queryContactContents", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryContactContent> QueryContactContents { get; set; }
    }

    public partial class QueryContactContent
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public QueryContactContentFlatData FlatData { get; set; }
    }

    public partial class QueryContactContentFlatData
    {
        [JsonProperty("heroTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroTitle { get; set; }

        [JsonProperty("heroHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroHeading { get; set; }

        [JsonProperty("heroImage", NullValueHandling = NullValueHandling.Ignore)]
        public List<HeroImage> HeroImage { get; set; }

        [JsonProperty("contactAddressLabel", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactAddressLabel { get; set; }

        [JsonProperty("contactAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactAddress { get; set; }

        [JsonProperty("contactMobileLabel", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMobileLabel { get; set; }

        [JsonProperty("contactMobile", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMobile { get; set; }

        [JsonProperty("contactEmailLabel", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactEmailLabel { get; set; }

        [JsonProperty("contactEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactEmail { get; set; }

        [JsonProperty("contactMap", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMap { get; set; }
    }

    public partial class HeroImage
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public String Url { get; set; }
    }
}