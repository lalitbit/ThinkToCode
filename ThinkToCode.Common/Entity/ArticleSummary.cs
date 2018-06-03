using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkToCode.Common.Entity
{
    public class ArticleSummary : ArticleEntity
    {


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
        /// Gets or sets the type of the article.
        /// </summary>
        /// <value>
        /// The type of the article.
        /// </value>
        public int ArticleType { get; set; }

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
        public string Summary { get; set; }
    }
}
