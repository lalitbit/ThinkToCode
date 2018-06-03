

namespace ThinkToCode.Business.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ThinkToCode.Common.Entity;

    /// <summary>
    /// Interface for Article business.
    /// </summary>
    public interface IArticleBusiness
    {
        /// <summary>
        /// Gets all article with summaries.
        /// </summary>
        /// <returns>Return list of article with summary</returns>
        IList<ArticleSummary> GetAllArticleWithSummaries();
    }
}
