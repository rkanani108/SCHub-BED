using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Services.Model;
using Web.Services.Model.Temple;

namespace Web.Services.Services
{
   public class TempleService : ITempleService
    {
        private readonly ISquindexService clientService;

        public TempleService(ISquindexService clientService)
        {
            this.clientService = clientService;
        }
        public async Task<QueryTempleData> GetResult()
        {
            var client = clientService.GetContent<Media, MediaData>("temple");

            var query = new
            {
                query = @"{
  queryTempleContents{
    id
    lastModified
    lastModifiedBy
    flatData{
      name
      shortDescription
      description
 templeImage {
       url
        thumbnailUrl
     }
      devPhotos{
        url
        thumbnailUrl
      }
      templePhotos{
        url
        thumbnailUrl
      }
    }
  }
  
}"
            };
            var result = await client.GraphQlAsync<QueryTempleData>(query);
           
            return result;
        }
    }
}
