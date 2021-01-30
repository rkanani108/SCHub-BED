using System.Linq;
using System.Threading.Tasks;
using Web.Services.Model;
using Web.Services.Model.About;
using Web.Services.Model.Careers;
using Web.Services.Model.Contact;
using Web.Services.Model.Portfolio;

namespace Web.Services
{
    public class HomeService : IHomeService
    {
        private readonly ISquindexService clientService;

        public HomeService(ISquindexService clientService)
        {
            this.clientService = clientService;
        }

        public async Task<HomeQueryData> Get()
        {
            var client = clientService.GetContent<Media, MediaData>("home");
            var query = new
            {
                query = @"
{
  queryHomeContents {
    id
    data {
      heroH1 {
        iv
      }
      heroH2 {
        iv
      }
      heroDescription {
        iv
      }
      heroCta1 {
        iv
      }
      heroCta2 {
        iv
      }
      heroImage {
        iv {
          url
        }
      }
      acH1 {
        iv
      }
      acDescription {
        iv
      }
      acCta1 {
        iv
      }
      acCta2 {
        iv
      }
      acImage {
        iv {
          url
        }
      }
     quotePrefix{
     iv
     }
      quoteText1 {
        iv
      }
      quoteText2 {
        iv
      }
      quoteText3 {
        iv
      }
      quoteDescription {
        iv
      }
      quoteImage {
        iv {
          url
        }
      }
      ethicsHeading1 {
        iv
      }
      ethicsDescription1 {
        iv
      }
      ethicsImage1 {
        iv {
          url
        }
      }
      ethicsHeading2 {
        iv
      }
      ethicsDescription2 {
        iv
      }
      ethicsImage2 {
        iv {
          url
        }
      }
      ethicsHeading3 {
        iv
      }
      ethicsDescription3 {
        iv
      }
      ethicsImage3 {
        iv {
          url
        }
      }
      projectHeading {
        iv
      }
      projectDescription {
        iv
      }
      projectLinks {
        iv {
          data {
            name {
              iv
            }
            type {
              iv
            }
            image {
              iv {
                url
                thumbnailUrl
              }
            }
          }
        }
      }
      teamHeading {
        iv
      }
      teamDescription {
        iv
      }
      teamLinks {
        iv {
          data {
            name {
              iv
            }
            designation {
              iv
            }
            facebook {
              iv
            }
            twitter {
              iv
            }
            image {
              iv {
                url
              }
            }
          }
        }
      }
      ctaContactLink {
        iv {
          flatData {
            ctaHeading
            ctaDescription
            ctaImage {
              url
            }
            ctaButtonText1
            ctaButtonLink1
            ctaButtonText2
            ctaButtonLink2
          }
        }
      }
      ctaContactExploreLink {
        iv {
          flatData {
            ctaHeading
            ctaDescription
            ctaImage {
              url
            }
            ctaButtonText1
            ctaButtonLink1
            ctaButtonText2
            ctaButtonLink2
          }
        }
      }
      ctaExploreLink {
        iv {
          flatData {
            ctaHeading
            ctaDescription
            ctaImage {
              url
            }
            ctaButtonText1
            ctaButtonLink1
            ctaButtonText2
            ctaButtonLink2
          }
        }
      }
    }
  }
}"
            };
            var result = await client.GraphQlAsync<HomeQueryResult>(query);
            var data = result.Items.FirstOrDefault().Data;
            return data;
        }

        public async Task<HeaderFlatData> GetHeader()
        {
            var client = clientService.GetContent<Media, MediaData>("home");
            var query = new
            {
                query = @"
{
  queryHeaderContents {
    id
    flatData {
      pageLinks {
        flatData {
          text
          link
        }
      }
      logo {
        url
      }
    }
  }
}
                "
            };
            var result = await client.GraphQlAsync<Result>(query);
            var data = result.QueryHeaderContents.FirstOrDefault().FlatData;
            return data;
        }

        public async Task<TopHeaderFlatData> GetTopHeader()
        {
            var client = clientService.GetContent<Media, MediaData>("home");
            var query = new
            {
                query = @"
{
  queryHeaderContents {
    id
    flatData {
      socialLink {
        flatData {
          socialIconLinks {
            flatData {
              socialClass
            }
          }
          socialTitle
          socialUrl
        }
      }
      workTime
      email
      mobile
    }
  }
}
                "
            };
            var result = await client.GraphQlAsync<TopHeaderQueryResult>(query);
            var data = result.queryHeaderContents.FirstOrDefault().flatData;
            return data;
        }

        public async Task<QueryFooterContentFlatData> GetFooter()
        {
            var client = clientService.GetContent<Media, MediaData>("home");
            var query = new
            {
                query = @"
{
  queryFooterContents {
    id
    flatData {
      aboutHeading
      aboutDescription
      photoHeading
      photoImageLinks {
        flatData {
          image {
            url
          }
        }
      }
      usefulLinkHeading
      usefulPageLinks {
        flatData {
          text
          link
        }
      }
      contactHeading
      address
      mobile
      emailWebsite
      copyrightText
      socialLinks {
        flatData {
          socialTitle
          socialUrl
          socialIconLinks {
            flatData {
              socialClass
            }
          }
        }
      }
    }
  }
}
                "
            };
            var result = await client.GraphQlAsync<FooterResult>(query);
            var data = result.QueryFooterContents.FirstOrDefault().FlatData;
            return data;
        }

        public async Task<QueryAboutPageContentFlatData> GetAbout()
        {
            var client = clientService.GetContent<Media, MediaData>("home");
            var query = new
            {
                query = @"
{
  queryAboutUsContents {
    id
    flatData {
      heroHeading
      heroDescription
      heroCtaText
      heroCtaLink
      heroImage {
        url
      }
      aboutTitle
      aboutHeading
      aboutDescription
      aboutCtaText
      aboutCtaLink
      aboutLeftImg1 {
        url
      }
      aboutLeftImg2 {
        url
      }
      aboutRightImg {
        url
      }
      stateImg {
        url
      }
      stateIcon1 {
        flatData {
          iconClass
        }
      }
      stateText1
      stateCount1
      stateIcon2 {
        flatData {
          iconClass
        }
      }
      stateText2
      stateCount2
      stateIcon3 {
        flatData {
          iconClass
        }
      }
      stateText3
      stateCount3
      stateIcon4 {
        flatData {
          iconClass
        }
      }
      stateText4
      stateCount4
      teamHeading
      teamDescription
      teamLinks {
        flatData {
          name
          designation
          image {
            url
          }
          facebook
          twitter
        }
      }
      customerHeading
      customerDescription
      customerLinks {
        flatData {
          image {
            url
          }
          description
          name
          designation
        }
      }
      ctaContactLink {
        flatData {
          ctaHeading
          ctaDescription
          ctaEmail
          ctaMobileNumber
          ctaButtonText1
          ctaButtonLink1
        }
      }
    }
  }
}
                "
            };
            var result = await client.GraphQlAsync<QueryAboutPageContentResult>(query);
            var data = result.QueryAboutPageContents.FirstOrDefault().FlatData;
            return data;
        }

        public async Task<QueryPortfolioContentFlatData> GetPortfolio()
        {
            var client = clientService.GetContent<Media, MediaData>("home");
            var query = new
            {
                query = @"
{
  queryPortfolioContents {
    id
    flatData {
      heroHeading
      heroDescription
      heroCtaButtonText1
      heroCtaButtonLink1
      heroCtaButtonText2
      heroCtaButtonLink2
      heroImage1 {
        url
      }
      heroImage2 {
        url
      }
      heroImage3 {
        url
      }
      recentProjectHeading
      recentProjectDescription
      recentProjectLinks {
        flatData {
          image {
            url
          }
          name
          type
          projectDescription
        }
      }
      ctaBlockLink {
        flatData {
          ctaHeading
          ctaDescription
          ctaButtonText1
          ctaButtonLink1
        }
      }
      projectHeading
      projectDescription
      projectLinks {
        flatData {
          image {
            url
          }
          name
          type
          projectDescription
        }
      }
      ctaContactLink {
        flatData {
          ctaHeading
          ctaDescription
          ctaEmail
          ctaMobileNumber
          ctaButtonText1
          ctaButtonLink1
        }
      }
    }
  }
}
                "
            };
            var result = await client.GraphQlAsync<QueryPortfolioContentResult>(query);
            var data = result.QueryPortfolioContents.FirstOrDefault().FlatData;
            return data;
        }

        public async Task<QueryCareersContentFlatData> GetCareers()
        {
            var client = clientService.GetContent<Media, MediaData>("home");
            var query = new
            {
                query = @"
{
  queryCareersContents {
    id
    flatData {
      heroHeading
      heroDescription
      heroCtaText
      heroCtaLink
      heroImage {
        url
      }
      hiringTitle
      hiringHeading
      hiringDescription
      hiringPersonImage {
        url
      }
      hiringPersonQuota
      hiringPersonName
      hiringBackgroundImage {
        url
      }
      hiringStatement
      ctaBlockLink {
        flatData {
          ctaHeading
          ctaDescription
          ctaEmail
          ctaMobileNumber
          ctaButtonText1
          ctaButtonLink1
        }
      }
    }
  }
}
                "
            };
            var result = await client.GraphQlAsync<QueryCareersContentResult>(query);
            var data = result.QueryCareersContents.FirstOrDefault().FlatData;
            return data;
        }

        public async Task<QueryContactContentFlatData> GetContact()
        {
            var client = clientService.GetContent<Media, MediaData>("home");
            var query = new
            {
                query = @"
{
  queryContactContents {
    id
    flatData {
      heroTitle
      heroHeading
      heroImage {
        url
      }
      contactAddressLabel
      contactAddress
      contactMobileLabel
      contactMobile
      contactEmailLabel
      contactEmail
      contactMap
    }
  }
}

                "
            };
            var result = await client.GraphQlAsync<QueryContactContentResult>(query);
            var data = result.QueryContactContents.FirstOrDefault().FlatData;
            return data;
        }
    }
}