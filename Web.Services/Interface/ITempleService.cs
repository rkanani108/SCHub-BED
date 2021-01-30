using System.Threading.Tasks;
using Web.Services.Model;
using Web.Services.Model.About;
using Web.Services.Model.Careers;
using Web.Services.Model.Contact;
using Web.Services.Model.Portfolio;
using Web.Services.Model.Temple;

namespace Web.Services
{
    public interface ITempleService
    {


        Task<QueryTempleData> GetResult();

    

        // Task<HomeQueryData> GetFooter();
    }
}