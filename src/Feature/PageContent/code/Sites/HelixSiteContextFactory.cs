using System;
using Sitecore.Diagnostics;
using Sitecore.Sites;
using Sitecore.StringExtensions;
using Sitecore.Web;

namespace Sitecore.Feature.PageContent.Sites
{
    public class HelixSiteContextFactory : DefaultSiteContextFactory
    {
        public override SiteContext GetSiteContext(string hostName, string fullPath, int portNumber)
        {
            Assert.ArgumentNotNull((object)hostName, nameof(hostName));
            Assert.ArgumentNotNull((object)fullPath, nameof(fullPath));
            fullPath = fullPath.ToLowerInvariant();
            foreach (var site in this.GetSites())
            {
                if (!this.HasDirectDomainMatch(site, hostName, fullPath))
                {
                    continue;
                }

                if (site.Matches(hostName, fullPath, portNumber))
                {
                    return new SiteContext(site);
                }
            }
            return null;
        }

        protected bool HasDirectDomainMatch(SiteInfo site, string hostName, string fullPath)
        {
            if (site.TargetHostName.IsNullOrEmpty())
            {
                return true;
            }

            if (fullPath.StartsWith("/sitecore"))
            {
                return false;
            }

            return site.TargetHostName.Equals(hostName, StringComparison.InvariantCultureIgnoreCase) ||
                   site.HostName.Contains(hostName);
        }
    }
}
