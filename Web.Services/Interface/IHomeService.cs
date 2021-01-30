using System.Threading.Tasks;
using Web.Services.Model;
using Web.Services.Model.About;
using Web.Services.Model.Careers;
using Web.Services.Model.Contact;
using Web.Services.Model.Portfolio;

namespace Web.Services
{
    public interface IHomeService
    {
        Task<HomeQueryData> Get();

        Task<TopHeaderFlatData> GetTopHeader();

        Task<HeaderFlatData> GetHeader();

        Task<QueryFooterContentFlatData> GetFooter();

        Task<QueryAboutPageContentFlatData> GetAbout();

        Task<QueryPortfolioContentFlatData> GetPortfolio();

        Task<QueryCareersContentFlatData> GetCareers();

        Task<QueryContactContentFlatData> GetContact();

        // Task<HomeQueryData> GetFooter();
    }
}