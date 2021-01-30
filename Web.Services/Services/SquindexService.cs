using Microsoft.Extensions.Options;
using Squidex.ClientLibrary;
using System;
using System.Net.Http;
using Web.Services.Model;

namespace Web.Services
{
    public class SquindexService : ISquindexService
    {
        public SquidexClientManager client;
        private IOptions<SquindexSettings> settings;

        [Obsolete]
        public SquindexService(IOptions<SquindexSettings> settings)
        {
            this.settings = settings;
            client = new SquidexClientManager(this.settings.Value.Url, this.settings.Value.AppName, this.settings.Value.ClientId, this.settings.Value.ClientSecret);
            // client = new SquidexClientManager("https://cloud.squidex.io/","tej-web-us", "tej-web-us:default", "3hlr6gl7tzgoqxlxv0dbokcdi8rusgbtmcxv21zlnpkx");
        }

        public IContentsClient<TEntity, TData> GetContent<TEntity, TData>(string schemaName)
            where TEntity : Content<TData>
            where TData : class, new()
        {
            return client.CreateContentsClient<TEntity, TData>(schemaName);
        }

        public HttpClient GetHttpClient()
        {
            return client.CreateHttpClient();
        }
    }
}