
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
        public IList<ArticleSummary> GetAllArticleSummary(string category)
        {
            IList<ArticleSummary> articles = this.articleBusiness.GetAllArticleWithSummaries(category);
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
            var articles = this.articleBusiness.GetArticle(articleSummary);
            return articles;
        }

        /// <summary>
        /// Gets the user comments.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IList<UserComment> GetUserComments(string id)
        {
            return this.articleBusiness.GetUserComments(id);
        }

        /// <summary>
        /// Saves the user comment.
        /// </summary>
        /// <param name="userCommnet">The user commnet.</param>
        /// <returns></returns>
        public bool SaveUserComment(UserComment userCommnet)
        {
            return this.articleBusiness.SaveUserComment(userCommnet);
        }
    }
}
