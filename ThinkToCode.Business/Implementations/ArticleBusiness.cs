
namespace ThinkToCode.Business.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Common.Enumeration;
    using Repository.Contract;
    using ThinkToCode.Business.Contracts;
    using ThinkToCode.Common.Entity;

    /// <summary>
    /// Class implementation for interface.
    /// </summary>
    /// <seealso cref="ThinkToCode.Business.Contracts.IArticleBusiness" />
    public class ArticleBusiness : IArticleBusiness
    {
        /// <summary>
        /// The article repository
        /// </summary>
        IArticleRepository articleRepository;

        public ArticleBusiness(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }
        /// <summary>
        /// Gets all article with summaries.
        /// </summary>
        /// <returns>
        /// Return list of article with summary
        /// </returns>
        public IList<ArticleSummary> GetAllArticleWithSummaries(string category)
        {
            return this.articleRepository.GetArticlesSnapShots(category);
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
            var article = this.articleRepository.GetArticlesBySeoTitle(articleSummary.SeoTitle);
            if (article != null && articleSummary.IncludeComments)
            {
                article.UserComments = this.GetUserComments(article.FileKey);
            }

            return article;
        }

        public IList<UserComment> GetUserComments(string id)
        {
            return this.articleRepository.GetUserComments(id);
        }

        public bool SaveUserComment(UserComment userCommnet)
        {
            throw new NotImplementedException();
        }
    }
}
