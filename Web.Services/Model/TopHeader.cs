using System.Collections.Generic;

namespace Web.Services.Model
{
    public class SocialIconFlatData
    {
        public string socialClass { get; set; }
    }

    public class SocialFlatData
    {
        public IList<SocialIconLink> socialIconLinks { get; set; }
        public string socialTitle { get; set; }
        public string socialUrl { get; set; }
    }

    public class TopHeaderFlatData
    {
        public IList<SocialLink> socialLink { get; set; }
        public string workTime { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
    }

    public class QueryTopHeaderContent
    {
        public string id { get; set; }
        public TopHeaderFlatData flatData { get; set; }
    }

    public class TopHeaderQueryResult
    {
        public IList<QueryTopHeaderContent> queryHeaderContents { get; set; }
    }
}