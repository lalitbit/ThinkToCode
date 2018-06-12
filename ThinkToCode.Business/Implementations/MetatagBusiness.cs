

namespace ThinkToCode.Business.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Repository.Contract;
    using ThinkToCode.Business.Contracts;
    using ThinkToCode.Common.Entity;

    /// <summary>
    /// Class for meta tag business.
    /// </summary>
    public class MetatagBusiness : IMetatagBusiness
    {
        IMetaDataRepository metaDataRepository;

        public MetatagBusiness(IMetaDataRepository metaDataRepository)
        {
            this.metaDataRepository = metaDataRepository;
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
            return this.metaDataRepository.GetMetatags(id);
           // return this.GetMetatagsForIndexPage_Dummy();
        }

        /// <summary>
        /// Gets the metatags for index page.
        /// </summary>
        /// <returns>
        /// Return the meta data information for index/home page.
        /// </returns>
        public Metadata GetMetatagsForIndexPage()
        {
            return this.metaDataRepository.GetMetatags("indexpage");

            // return this.GetMetatagsForIndexPage_Dummy();
        }
    }
}
