

namespace ThinkToCode.Services.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ThinkToCode.Common.Entity;

    /// <summary>
    /// Interface for meta tag.
    /// </summary>
    public interface IMetatagService
    {
        /// <summary>
        /// Gets the metatags for index page.
        /// </summary>
        /// <returns>Return the meta data information for index/home page.</returns>
        Metadata GetMetatagsForIndexPage();

        /// <summary>
        /// Gets the metatags.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Return the meta data information.</returns>
        Metadata GetMetatags(string id);
    }
}
