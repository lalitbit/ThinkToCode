
namespace ThinkToCode.Business.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ThinkToCode.Business.Contracts;
    using ThinkToCode.Common.Entity;

    /// <summary>
    /// Class implementation for interface.
    /// </summary>
    /// <seealso cref="ThinkToCode.Business.Contracts.IArticleBusiness" />
    public class ArticleBusiness : IArticleBusiness
    {
        /// <summary>
        /// Gets all article with summaries.
        /// </summary>
        /// <returns>
        /// Return list of article with summary
        /// </returns>
        public IList<ArticleSummary> GetAllArticleWithSummaries()
        {
            return this.GetDummyDataForArticleSumaries();
        }

        /// <summary>
        /// Gets the dummy data for article sumaries.
        /// </summary>
        /// <returns>
        /// Return list of article with summary
        /// </returns>      
        private IList<ArticleSummary> GetDummyDataForArticleSumaries()
        {
            var articles = new List<ArticleSummary>();
            articles.Add(new ArticleSummary
            {
                Tile = "Visitor Pattern - ReExplained !!",
                SeoTitle = "Visitor-Pattern-ReExplained",
                WrittenOn = "March 17, 2018",
                ArticleType = (int)ArticleTypeEnum.DesingArchitecture,
                Summary = "Visitor Pattern is, in general opinion, is the most complicated design pattern because of the nature of problem it solves. We will look what it is, how it works and how it should be implemented in real scenarios.<o:p>" +
                "Every one among us might get into the situation, when we have a complex class hierarchy and we want to add or modify their behaviors without changing their original code.The “Complex” word I have used because in the hierarchy, every object are of different types and we want to add operation which will run on specific type’s.i.e.different operation for different types of object. Frankly saying, most of time we do type/instance checking to determine the type and then select the operation via If-else statement.This approach has its own limitations and, of course, not an object oriented way.To fix this type of problems in an object oriented way – Visitor Pattern came into picture."
            });

            return articles;
        }
    }
}
