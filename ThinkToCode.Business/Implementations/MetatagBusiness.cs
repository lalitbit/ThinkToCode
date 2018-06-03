

namespace ThinkToCode.Business.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ThinkToCode.Business.Contracts;
    using ThinkToCode.Common.Entity;

    /// <summary>
    /// Class for meta tag business.
    /// </summary>
    public class MetatagBusiness : IMetatagBusiness
    {
        /// <summary>
        /// Gets the metatags.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// Return the meta data information.
        /// </returns>
        public Metadata GetMetatags(string id)
        {
            return this.GetMetatagsForIndexPage_Dummy();
        }

        /// <summary>
        /// Gets the metatags for index page.
        /// </summary>
        /// <returns>
        /// Return the meta data information for index/home page.
        /// </returns>
        public Metadata GetMetatagsForIndexPage()
        {
            return this.GetMetatagsForIndexPage_Dummy();
        }

        private Metadata GetMetatagsForIndexPage_Dummy()
        {
            var metatdata= new Metadata
            {
                Description = "Blog for .net developer",
                Author = "Lalit Chandra",
                Copyright = "www.lalitchandra.in",
                Url = "www.lalitchandra.in",
                Robots = ""
            };

            this.AddDescriptionAndKeywordMetadata(metatdata);
            return metatdata;
        }

        private void AddDescriptionAndKeywordMetadata(Metadata metadata)
        {
            metadata.Description = "Learn Desing, Learn architecture design,Learn about sotware desing principle, Microsoft Azure Tutorial for Beginners - Learn Microsoft Azure in simple and easy steps starting from basic to advanced concepts with examples including Cloud Computing Overview, Windows Azure, Components, Compute Module, Fabric Controller, Storage, Blobs, Queues, Tables, CDN, Applications, Security, Datacenters, Scenarios, Management Portal, Create Virtual Network, Deploying Virtual Machines, Endpoint Configuration, Point-to-Site, Site-to-Site Connectivity, Traffic Manager, PowerShell, Monitoring Virtual Machines, Setting Up Alert Rules, Application Deployment, Backup and Recovery, Self-Service Capabilities, Multi-Factor Authentication, Forefront Identity Manager, Data Import and Export Job, Websites, Scalability, Disk Configuration, Disk Caching, Personalize Azure Access, Personalize Company Branding, Self-Service Password Reset, Group Management, Create a Group, Security Reports and Alerts, Orchestrated Recovery, Health Monitoring, Upgrades.";
            metadata.Keywords = "Desing, Architecture, Desing priciple, Microsoft Azure, Tutorial, Learning, Beginners, Cloud Computing Overview, Windows Azure, Components,Azure Storage,Azure Blobs,Azure Queues,Azure Tables,Azure CDN, Applications, Security, Datacenters, Scenarios, Management Portal, Create Virtual Network, Deploying Virtual Machines, Endpoint Configuration, Point-to-Site, Site-to-Site Connectivity, Traffic Manager, PowerShell, Monitoring Virtual Machines, Setting Up Alert Rules, Application Deployment, Backup and Recovery, Self-Service Capabilities, Multi-Factor Authentication, Forefront Identity Manager, Data Import and Export Job, Websites, Scalability, Disk Configuration, Disk Caching, Personalize Azure Access, Personalize Company Branding, Self-Service Password Reset, Group Management, Create a Group, Security Reports and Alerts, Orchestrated Recovery, Health Monitoring, Upgrades.";
        }
    }
}
