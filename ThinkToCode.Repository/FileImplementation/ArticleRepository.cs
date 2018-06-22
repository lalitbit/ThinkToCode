using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity;
using ThinkToCode.Common.Enumeration;
using ThinkToCode.Repository.Common;
using ThinkToCode.Repository.Contract;
using ThinkToCode.Repository.DbData;

namespace ThinkToCode.Repository.FileImplementation
{
    public class ArticleRepository : Common.BaseRepository<ArticleEntity>, IArticleRepository
    {
        /// <summary>
        /// The article data
        /// </summary>
        ArticleDataTable articleData;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleRepository" /> class.
        /// </summary>
        public ArticleRepository()
        {
            articleData = ArticleDataTable.Instance;
        }


        /// <summary>
        /// Gets the articles by seo title.
        /// </summary>
        /// <param name="seoTitle">The seo title.</param>
        /// <returns>
        /// Return the article summary.
        /// </returns>
        public ArticleSummary GetArticlesBySeoTitle(string seoTitle)
        {
            var article = this.articleData.PopulateArticles().Where(x => string.Compare(x.SeoTitle, seoTitle, true) == 0).First();
            return new ArticleSummary { FileName = string.Format("{0}.cshtml", article.FileKey) };
        }

        /// <summary>
        /// Gets the articles snap shots.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <returns>
        /// Return the list of article summaries.
        /// </returns>
        public IList<ArticleSummary> GetArticlesSnapShots(string category)
        {
            HashSet<int> topicIds = new HashSet<int>();
            var articleSummaries = new List<ArticleSummary>();
            IList<ArticleEntity> articleEntities = new List<ArticleEntity>();
            articleEntities = this.articleData.PopulateArticles();

            if (!string.IsNullOrEmpty(category))
            {
                var menuItem = MenuDataTable.Instance.PopulateMenu();

                var menu = menuItem.Menus.Where(x => string.Equals(x.UrlNameOrDefault, category, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (menu != null)
                {
                    topicIds = new HashSet<int>(menuItem.SubMenuMappings.Where(x => x.MenuId == menu.Id).Select(x => x.SubMenuId));
                }
                else
                {
                    menu = menuItem.SubMenus.Where(x => string.Equals(x.UrlNameOrDefault, category, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                    if (menu != null)
                    {
                        topicIds.Add(menu.Id);
                    }
                }
            }

            if (topicIds.Any())
            {
                articleEntities = articleEntities.Where(X => topicIds.Contains(X.TopicId)).ToList();
            }

            foreach (var article in articleEntities)
            {
                articleSummaries.Add(new ArticleSummary
                {
                    Id = article.Id,
                    WrittenOn = article.WrittenOn,
                    Tile = article.Tile,
                    SeoTitle = article.SeoTitle,
                    Description = article.Description
                });
            }

            return articleSummaries;
        }

        /// <summary>
        /// Gets the user comments.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// Return the list of user comments.
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public IList<UserComment> GetUserComments(string id)
        {
            return new List<UserComment> {
                new UserComment {UserName="Santokh",Comment="Nice article"  },
                new UserComment {UserName="Manish",Comment="Nice article"  },
                new UserComment {UserName="Ravi",Comment="Nice article"  },
                new UserComment {UserName="Kedar Nath",Comment="Nice article"  },
                new UserComment {UserName="Sachin Tendulkar",Comment="Nice article"  },
                new UserComment {UserName="Ram Krishna",Comment="Nice article"  }
            };
        }

        /// <summary>
        /// Saves the user comment.
        /// </summary>
        /// <param name="userCommnet">The user commnet.</param>
        /// <returns>
        /// Return the status.
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SaveUserComment(UserComment userCommnet)
        {
            throw new NotImplementedException();
        }
    }
}
