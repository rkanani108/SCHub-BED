using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Web.Services.Model.Portfolio
{
    public partial class QueryPortfolioContentResult
    {
        [JsonProperty("queryPortfolioContents", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryPortfolioContent> QueryPortfolioContents { get; set; }
    }

    public partial class QueryPortfolioContent
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public QueryPortfolioContentFlatData FlatData { get; set; }
    }

    public partial class QueryPortfolioContentFlatData
    {
        [JsonProperty("heroHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroHeading { get; set; }

        [JsonProperty("heroDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroDescription { get; set; }

        [JsonProperty("heroCtaButtonText1", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroCtaButtonText1 { get; set; }

        [JsonProperty("heroCtaButtonLink1", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroCtaButtonLink1 { get; set; }

        [JsonProperty("heroCtaButtonText2", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroCtaButtonText2 { get; set; }

        [JsonProperty("heroCtaButtonLink2", NullValueHandling = NullValueHandling.Ignore)]
        public string HeroCtaButtonLink2 { get; set; }

        [JsonProperty("heroImage1", NullValueHandling = NullValueHandling.Ignore)]
        public List<HeroImage1> HeroImage1 { get; set; }

        [JsonProperty("heroImage2", NullValueHandling = NullValueHandling.Ignore)]
        public List<HeroImage1> HeroImage2 { get; set; }

        [JsonProperty("heroImage3", NullValueHandling = NullValueHandling.Ignore)]
        public List<HeroImage1> HeroImage3 { get; set; }

        [JsonProperty("recentProjectHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string RecentProjectHeading { get; set; }

        [JsonProperty("recentProjectDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string RecentProjectDescription { get; set; }

        [JsonProperty("recentProjectLinks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProjectLink> RecentProjectLinks { get; set; }

        [JsonProperty("ctaBlockLink", NullValueHandling = NullValueHandling.Ignore)]
        public List<CtaLink> CtaBlockLink { get; set; }

        [JsonProperty("projectHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectHeading { get; set; }

        [JsonProperty("projectDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectDescription { get; set; }

        [JsonProperty("projectLinks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProjectLink> ProjectLinks { get; set; }

        [JsonProperty("ctaContactLink", NullValueHandling = NullValueHandling.Ignore)]
        public List<CtaLink> CtaContactLink { get; set; }
    }

    public partial class CtaLink
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

    public partial class HeroImage1
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public partial class ProjectLink
    {
        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectLinkFlatData FlatData { get; set; }
    }

    public partial class ProjectLinkFlatData
    {
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public List<HeroImage1> Image { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("projectDescription")]
        public string ProjectDescription { get; set; }
    }
}