using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Business.Contracts;
using ThinkToCode.Common.Entity;
using ThinkToCode.Services.Contract;

namespace ThinkToCode.Services.Implementation
{
    /// <summary>
    /// Class for meta data tags.
    /// </summary>
    /// <seealso cref="ThinkToCode.Services.Contract.IMetatag" />
    public class MetatagService : IMetatagService
    {
        /// <summary>
        /// The metatag business
        /// </summary>
        private IMetatagBusiness metatagBusiness;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetatagService"/> class.
        /// </summary>
        public MetatagService(IMetatagBusiness metatagBusiness)
        {
            this.metatagBusiness = metatagBusiness;
        }

        /// <summary>
        /// Gets the metatags.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// Return the meta data information.
        /// </returns>
        public Metadata GetMetatags(string id)
        {
            return this.metatagBusiness.GetMetatags(id);
        }

        /// <summary>
        /// Gets the metatags for index page.
        /// </summary>
        /// <returns>
        /// Return the meta data information for index/home page.
        /// </returns>
        public Metadata GetMetatagsForIndexPage()
        {
            return this.metatagBusiness.GetMetatagsForIndexPage();
        }
    }
}
