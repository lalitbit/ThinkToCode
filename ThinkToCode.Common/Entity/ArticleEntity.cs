using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkToCode.Common.Entity
{
    public class ArticleEntity : BaseEntity
    {
        public ArticleEntity()
        {
            this.UserComments = new List<UserComment>();
        }
        public int TopicId { get; set; }

        /// <summary>
        /// Gets or sets the tile.
        /// </summary>
        /// <value>
        /// The tile.
        /// </value>
        public string Tile { get; set; }

        /// <summary>
        /// Gets or sets the title optimized for SEO (Search Engine Optimization).
        /// </summary>
        /// <value>
        /// The seo title.
        /// </value>
        public string SeoTitle { get; set; }

        /// <summary>
        /// Gets or sets the file key.
        /// </summary>
        /// <value>
        /// The file key.
        /// </value>
        public string FileKey { get; set; }

        /// <summary>
        /// Gets or sets the date string of article written on.
        /// </summary>
        /// <value>
        /// The written on.
        /// </value>
        public string WrittenOn { get; set; }

        /// <summary>
        /// Gets or sets the article summary/description.
        /// </summary>
        /// <value>
        /// The summary.
        /// </value>
        public string Description { get; set; }

        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the user comments.
        /// </summary>
        /// <value>
        /// The user comments.
        /// </value>
        public IList<UserComment> UserComments { get; set; }
    }
}
