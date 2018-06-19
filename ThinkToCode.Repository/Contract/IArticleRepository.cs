using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity;

namespace ThinkToCode.Repository.Contract
{
    public interface IArticleRepository
    {
        IList<ArticleSummary> GetArticlesSnapShots(string category);

        ArticleSummary GetArticlesBySeoTitle(string seoTitle);
    }
}
