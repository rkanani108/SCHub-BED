using Newtonsoft.Json;
using Squidex.ClientLibrary;
using System;
using System.Collections.Generic;

namespace Web.Services.Model
{
    public sealed class HomeQueryData
    {
        //Hero
        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("heroH1")]
        public string HeroHeading1 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("heroH2")]
        public string HeroHeading2 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("heroDescription")]
        public string HeroDescription { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("heroCta1")]
        public string HeroCta1 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("heroCta2")]
        public string HeroCta2 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("heroImage")]
        public List<Image> HeroImage { get; set; }

        //About
        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("acH1")]
        public string AboutHeading { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("acDescription")]
        public string AboutDescription { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("acCta1")]
        public string AboutCta1 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("acCta2")]
        public string AboutCta2 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("acImage")]
        public List<Image> AboutImage { get; set; }

        //Quote
        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("quotePrefix")]
        public string QuotePrefix { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("quoteText1")]
        public string Quote1 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("quoteText2")]
        public string Quote2 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("quoteText3")]
        public string Quote3 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("quoteDescription")]
        public string QuoteDescription { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("quoteImage")]
        public List<Image> QuoteImage { get; set; }

        //Ethic
        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsHeading1")]
        public string EthicHeading1 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsDescription1")]
        public string EthicDescription1 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsImage1")]
        public List<Image> EthicImage1 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsHeading2")]
        public string EthicHeading2 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsDescription2")]
        public string EthicDescription2 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsImage2")]
        public List<Image> EthicImage2 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsHeading3")]
        public string EthicHeading3 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsDescription3")]
        public string EthicDescription3 { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ethicsImage3")]
        public List<Image> EthicImage3 { get; set; }

        //Projects
        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("projectHeading")]
        public string ProjectHeading { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("projectDescription")]
        public string ProjectDescription { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("projectLinks")]
        public List<Projects> ProjectLinks { get; set; }

        //Team
        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("teamHeading")]
        public string TeamHeading { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("teamDescription")]
        public string TeamDescription { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("teamLinks")]
        public List<Team> TeamLinks { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ctaContactLink")]
        public List<CtaBlock> CtaBlockContact { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ctaExploreLink")]
        public List<CtaBlock> CtaBlockExplore { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("ctaContactExploreLink")]
        public List<CtaBlock> CtaBlockContactExplore { get; set; }
    }

    public sealed class CtaBlock
    {
        public CtaBlockData FlatData { get; set; }
    }

    public sealed class CtaBlockData
    {
        [JsonProperty("ctaHeading")]
        public string CtaBlockHeading { get; set; }

        [JsonProperty("ctaDescription")]
        public string CtaBlockDescription { get; set; }

        [JsonProperty("ctaButtonText1")]
        public string CtaBlockButtonText1 { get; set; }

        [JsonProperty("ctaButtonLink1")]
        public string CtaBlockButtonLink1 { get; set; }

        [JsonProperty("ctaButtonText2")]
        public string CtaBlockButtonText2 { get; set; }

        [JsonProperty("ctaButtonLink2")]
        public string CtaBlockButtonLink2 { get; set; }

        [JsonProperty("ctaImage")]
        public List<Image> CtaBlockImage { get; set; }
    }

    public sealed class Projects
    {
        public ProjectData Data { get; set; }
    }

    public sealed class ProjectData
    {
        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("type")]
        public string ProjectType { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("image")]
        public List<Image> ProjectImage { get; set; }
    }

    public sealed class Team
    {
        public TeamData Data { get; set; }
    }

    public sealed class TeamData
    {
        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("name")]
        public string TeamName { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("designation")]
        public string TeamDesignation { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("facebook")]
        public string TeamFacebook { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("twitter")]
        public string TeamTwitter { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        [JsonProperty("image")]
        public List<Image> TeamImage { get; set; }
    }

    public class Image
    {
        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbUrl { get; set; }
    }

    public sealed class HomeQuery
    {
        public Guid Id { get; set; }

        public HomeQueryData Data { get; set; }
    }

    public sealed class HomeQueryResult
    {
        [JsonProperty("queryHomeContents")]
        public HomeQuery[] Items { get; set; }
    }
}