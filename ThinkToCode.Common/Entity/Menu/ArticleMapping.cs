using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkToCode.Common.Entity.Menu
{
    public class ArticleMapping : BaseEntity
    {
        public string ArticleName { get; set; }
        public string ArtilceUrlName { get; set; }
        public Guid FileKey { get; set; }
        public int SubMenuId { get; set; }
    }
}
