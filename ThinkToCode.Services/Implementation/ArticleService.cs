
namespace ThinkToCode.Services.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Business.Contracts;
    using ThinkToCode.Common.Entity;
    using ThinkToCode.Services.Contract;

    /// <summary>
    /// Class to implement article service.
    /// </summary>
    /// <seealso cref="ThinkToCode.Services.Contract.IArticleService" />
    public class ArticleService : IArticleService
    {
        /// <summary>
        /// The article business
        /// </summary>
        private IArticleBusiness articleBusiness;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleService"/> class.
        /// </summary>
        /// <param name="articleBusiness">The article business.</param>
        public ArticleService(IArticleBusiness articleBusiness)
        {
            this.articleBusiness = articleBusiness;
        }

        /// <summary>
        /// Gets all article summary.
        /// </summary>
        /// <returns>
        /// Return the list of articles summary.
        /// </returns>
        public IList<ArticleSummary> GetAllArticleSummary()
        {
            IList<ArticleSummary> articles = this.articleBusiness.GetAllArticleWithSummaries();
            return articles;
        }

        /// <summary>
        /// Gets the article.
        /// </summary>
        /// <param name="articleSummary">The article summary.</param>
        /// <returns>
        /// Return the specific article.
        /// </returns>
        public ArticleEntity GetArticle(ArticleSummary articleSummary)
        {
            throw new NotImplementedException();
        }
    }
}
