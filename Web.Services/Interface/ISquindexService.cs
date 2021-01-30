using Squidex.ClientLibrary;
using System.Net.Http;

namespace Web.Services
{
    public interface ISquindexService
    {
        IContentsClient<TEntity, TData> GetContent<TEntity, TData>(string schemaName)
           where TEntity : Content<TData>
           where TData : class, new();

        HttpClient GetHttpClient();
    }
}