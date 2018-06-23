using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Hosting;
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
        private IHostingEnvironment _env;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleRepository" /> class.
        /// </summary>
        public ArticleRepository(IHostingEnvironment _env)
        {
            articleData = ArticleDataTable.Instance;
            this._env = _env;
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
            return new ArticleSummary { FileName = string.Format("{0}.cshtml", article.FileKey), FileKey = article.FileKey };
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
            var userComments = new List<UserComment>();
            var file = Path.Combine(_env.WebRootPath, @"content\comment", id + ".xml");

            XElement root;
            if (File.Exists(file))
            {
                root = XElement.Load(file);
                foreach (var item in root.Elements())
                {
                    userComments.Add(new UserComment
                    {
                        Comment = item.Element("Comment").Value,
                        UserName = item.Element("Name").Value
                    });
                }
            }

            return userComments;
            //return new List<UserComment> {
            //    new UserComment {UserName="Santokh",Comment="Nice article"  },
            //    new UserComment {UserName="Manish",Comment="Nice article"  },
            //    new UserComment {UserName="Ravi",Comment="Nice article"  },
            //    new UserComment {UserName="Kedar Nath",Comment="Nice article"  },
            //    new UserComment {UserName="Sachin Tendulkar",Comment="Nice article"  },
            //    new UserComment {UserName="Ram Krishna",Comment="Nice article"  }
            //};
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
            var file = Path.Combine(_env.WebRootPath, @"content\comment", userCommnet.FileId + ".xml");

            XElement root;
            if (File.Exists(file))
                root = XElement.Load(file);
            else
                root = new XElement("Comments");

            root.Add(new XElement("Node",
                     new XElement("Name", userCommnet.UserName),
                     new XElement("Comment", userCommnet.Comment)));

            // root.Save(file);
            this.SaveToXML(root, file);
            return true;
        }

        private void SaveToXML(XElement element, string file)
        {
            FileStream fileStream = new FileStream(file, FileMode.Create);
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };
            XmlWriter writer = XmlWriter.Create(fileStream, settings);
            element.Save(writer);
            writer.Flush();
            fileStream.Flush();
            fileStream.Dispose();
        }
    }
}
