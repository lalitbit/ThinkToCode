

namespace ThinkToCode.Services.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ThinkToCode.Common.Entity;

    /// <summary>
    /// Interface for article service.
    /// </summary>
    public interface IArticleService
    {
        /// <summary>
        /// Gets all article summary.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <returns>
        /// Return the list of articles summary.
        /// </returns>
        IList<ArticleSummary> GetAllArticleSummary(string category);

        /// <summary>
        /// Gets the article.
        /// </summary>
        /// <param name="articleSummary">The article summary.</param>
        /// <returns>Return the specific article.</returns>
        ArticleEntity GetArticle(ArticleSummary articleSummary);

        /// <summary>
        /// Gets the user comments.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        IList<UserComment> GetUserComments(string id);

        /// <summary>
        /// Saves the user comment.
        /// </summary>
        /// <param name="userCommnet">The user commnet.</param>
        /// <returns></returns>
        bool SaveUserComment(UserComment userCommnet);
    }
}
