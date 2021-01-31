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
        public async Task<QueryTempleData> GetResult(int top, int skip)
        {
            var client = clientService.GetContent<Media, MediaData>("temple");
            string jsonquery = @"{
  queryTempleContents(top: {0} skip: {1}) {
    id
    lastModified
    lastModifiedBy
    flatData {
      name
      shortDescription
      description
      templeImage {
        url
        thumbnailUrl
      }
      devPhotos {
        url
        thumbnailUrl
      }
      templePhotos {
        url
        thumbnailUrl
      }
    }
  }
}";
            string grapgqlQuery = string.Format(jsonquery, top, skip);
            var query = new
            {
                query = grapgqlQuery
                //                query = @"{
                //  queryTempleContents(top: {top} skip: {skip}) {
                //    id
                //    lastModified
                //    lastModifiedBy
                //    flatData {
                //      name
                //      shortDescription
                //      description
                //      templeImage {
                //        url
                //        thumbnailUrl
                //      }
                //      devPhotos {
                //        url
                //        thumbnailUrl
                //      }
                //      templePhotos {
                //        url
                //        thumbnailUrl
                //      }
                //    }
                //  }
                //}"
            };
            var result = await client.GraphQlAsync<QueryTempleData>(query);

            return result;
        }
    }
}
