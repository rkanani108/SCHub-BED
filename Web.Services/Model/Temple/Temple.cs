using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Services.Model.Temple
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class DevPhoto
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class TemplePhoto
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class TempleImage
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class FlatData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }


        
               [JsonProperty("templeImage")]
        public List<TempleImage> TempleImage { get; set; }

        [JsonProperty("devPhotos")]
        public List<DevPhoto> DevPhotos { get; set; }

        [JsonProperty("templePhotos")]
        public List<TemplePhoto> TemplePhotos { get; set; }
    }

    public class QueryTempleContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("flatData")]
        public FlatData FlatData { get; set; }
    }

    public class QueryTempleData
    {
        [JsonProperty("queryTempleContents")]
        public List<QueryTempleContent> QueryTempleContents { get; set; }
    }




}
