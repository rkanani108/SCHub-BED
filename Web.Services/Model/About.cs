using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Web.Services.Model.About
{
    public partial class QueryAboutPageContentResult
    {
        [JsonProperty("queryAboutUsContents", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryAboutPageContent> QueryAboutPageContents { get; set; }
    }

    public partial class QueryAboutPageContent
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public QueryAboutPageContentFlatData FlatData { get; set; }
    }

    public partial class QueryAboutPageContentFlatData
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
        public List<AboutLeftImg1> HeroImage { get; set; }

        [JsonProperty("aboutTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string AboutTitle { get; set; }

        [JsonProperty("aboutHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string AboutHeading { get; set; }

        [JsonProperty("aboutDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string AboutDescription { get; set; }

        [JsonProperty("aboutCtaText", NullValueHandling = NullValueHandling.Ignore)]
        public string AboutCtaText { get; set; }

        [JsonProperty("aboutCtaLink", NullValueHandling = NullValueHandling.Ignore)]
        public string AboutCtaLink { get; set; }

        [JsonProperty("aboutLeftImg1", NullValueHandling = NullValueHandling.Ignore)]
        public List<AboutLeftImg1> AboutLeftImg1 { get; set; }

        [JsonProperty("aboutLeftImg2", NullValueHandling = NullValueHandling.Ignore)]
        public List<AboutLeftImg1> AboutLeftImg2 { get; set; }

        [JsonProperty("aboutRightImg", NullValueHandling = NullValueHandling.Ignore)]
        public List<AboutLeftImg1> AboutRightImg { get; set; }

        [JsonProperty("stateImg", NullValueHandling = NullValueHandling.Ignore)]
        public List<AboutLeftImg1> StateImg { get; set; }

        [JsonProperty("stateIcon1", NullValueHandling = NullValueHandling.Ignore)]
        public List<StateIcon> StateIcon1 { get; set; }

        [JsonProperty("stateText1", NullValueHandling = NullValueHandling.Ignore)]
        public string StateText1 { get; set; }

        [JsonProperty("stateCount1", NullValueHandling = NullValueHandling.Ignore)]
        public string StateCount1 { get; set; }

        [JsonProperty("stateIcon2", NullValueHandling = NullValueHandling.Ignore)]
        public List<StateIcon> StateIcon2 { get; set; }

        [JsonProperty("stateText2", NullValueHandling = NullValueHandling.Ignore)]
        public string StateText2 { get; set; }

        [JsonProperty("stateCount2", NullValueHandling = NullValueHandling.Ignore)]
        public string StateCount2 { get; set; }

        [JsonProperty("stateIcon3", NullValueHandling = NullValueHandling.Ignore)]
        public List<StateIcon> StateIcon3 { get; set; }

        [JsonProperty("stateText3", NullValueHandling = NullValueHandling.Ignore)]
        public string StateText3 { get; set; }

        [JsonProperty("stateCount3", NullValueHandling = NullValueHandling.Ignore)]
        public string StateCount3 { get; set; }

        [JsonProperty("stateIcon4", NullValueHandling = NullValueHandling.Ignore)]
        public List<StateIcon> StateIcon4 { get; set; }

        [JsonProperty("stateText4", NullValueHandling = NullValueHandling.Ignore)]
        public string StateText4 { get; set; }

        [JsonProperty("stateCount4", NullValueHandling = NullValueHandling.Ignore)]
        public string StateCount4 { get; set; }

        [JsonProperty("teamHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamHeading { get; set; }

        [JsonProperty("teamDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamDescription { get; set; }

        [JsonProperty("teamLinks", NullValueHandling = NullValueHandling.Ignore)]
        public List<TeamLink> TeamLinks { get; set; }

        [JsonProperty("customerHeading", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerHeading { get; set; }

        [JsonProperty("customerDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerDescription { get; set; }

        [JsonProperty("customerLinks", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomerLink> CustomerLinks { get; set; }

        [JsonProperty("ctaContactLink", NullValueHandling = NullValueHandling.Ignore)]
        public List<CtaContactLink> CtaContactLink { get; set; }
    }

    public partial class CtaContactLink
    {
        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public CtaContactLinkFlatData FlatData { get; set; }
    }

    public partial class CtaContactLinkFlatData
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

    public partial class AboutLeftImg1
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public partial class CustomerLink
    {
        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerLinkFlatData FlatData { get; set; }
    }

    public partial class CustomerLinkFlatData
    {
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public List<AboutLeftImg1> Image { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("designation", NullValueHandling = NullValueHandling.Ignore)]
        public string Designation { get; set; }
    }

    public partial class StateIcon
    {
        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public StateIcon1FlatData FlatData { get; set; }
    }

    public partial class StateIcon1FlatData
    {
        [JsonProperty("iconClass", NullValueHandling = NullValueHandling.Ignore)]
        public string IconClass { get; set; }
    }

    public partial class TeamLink
    {
        [JsonProperty("flatData", NullValueHandling = NullValueHandling.Ignore)]
        public TeamLinkFlatData FlatData { get; set; }
    }

    public partial class TeamLinkFlatData
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("designation", NullValueHandling = NullValueHandling.Ignore)]
        public string Designation { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public List<AboutLeftImg1> Image { get; set; }

        [JsonProperty("facebook", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Facebook { get; set; }

        [JsonProperty("twitter", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Twitter { get; set; }
    }
}