using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity;

namespace ThinkToCode.Repository.Contract
{
    /// <summary>
    /// Article repository class.
    /// </summary>
    public interface IArticleRepository
    {
        /// <summary>
        /// Gets the articles snap shots.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <returns>Return the list of article summaries.</returns>
        IList<ArticleSummary> GetArticlesSnapShots(string category);

        /// <summary>
        /// Gets the articles by seo title.
        /// </summary>
        /// <param name="seoTitle">The seo title.</param>
        /// <returns>Return the article summary.</returns>
        ArticleSummary GetArticlesBySeoTitle(string seoTitle);

        /// <summary>
        /// Gets the user comments.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Return the list of user comments.</returns>
        IList<UserComment> GetUserComments(string id);

        /// <summary>
        /// Saves the user comment.
        /// </summary>
        /// <param name="userCommnet">The user commnet.</param>
        /// <returns>Return the status.</returns>
        bool SaveUserComment(UserComment userCommnet);
    }
}
