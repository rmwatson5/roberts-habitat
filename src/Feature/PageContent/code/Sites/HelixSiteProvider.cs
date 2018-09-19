using System.Collections.Generic;
using System.Linq;
using Sitecore.Data;
using Sitecore.Diagnostics;
using Sitecore.Feature.PageContent.Models;
using Sitecore.Foundation.DataAccess.Extensions;
using Sitecore.Sites;
using Synthesis;

namespace Sitecore.Feature.PageContent.Sites
{
    public class HelixSiteProvider : SiteProvider
    {
        private const string SitesPath = "/sitecore/content/sites";
        protected Dictionary<string, Site> Sites = new Dictionary<string, Site>();

        public override Site GetSite(string siteName)
        {
            Assert.ArgumentNotNullOrEmpty(siteName, nameof(siteName));
            return !this.Sites.TryGetValue(siteName, out var site) ? null : site;
        }

        public override SiteCollection GetSites()
        {
            var database = Context.Database ?? Database.GetDatabase("web");
            var siteCollection = new SiteCollection();
            var sitesFolder = database.GetItem(SitesPath);
            var siteRoots = sitesFolder?.Children.AsStronglyTypedCollectionOf<I_BaseSiteRootItem>().Where(bsr => bsr != null);
            var sites = siteRoots?.Select(this.GetSite);
            siteCollection.AddRange(sites);
            return siteCollection;
        }

        protected Site GetSite(I_BaseSiteRootItem siteRoot)
        {
            var siteName = siteRoot.Name.SitecoreNameify();
            var siteProperties = siteRoot.AdditionalAttributes.GetDictionary();

            siteProperties.TryAdd("name", siteName);
            siteProperties.TryAdd("targetHostName", siteRoot.TargetHostName.RawValue);
            siteProperties.TryAdd("database", "web");
            siteProperties.TryAdd("virtualFolder", "/");
            siteProperties.TryAdd("physicalFolder", "/");
            siteProperties.TryAdd("rootPath", siteRoot.Path);
            siteProperties.TryAdd("startItem", "/home");
            siteProperties.TryAdd("domain", siteRoot.Domain.RawValue);
            siteProperties.TryAdd("allowDebug", siteRoot.AllowDebug.Value.ToString().ToLower());
            siteProperties.TryAdd("enablePreview", siteRoot.EnablePreview.Value.ToString().ToLower());
            siteProperties.TryAdd("mode", siteRoot.On.GetOnValue());
            siteProperties.TryAdd("scheme", siteRoot.Scheme.RawValue);
            siteProperties.TryAdd("requireLogin", siteRoot.RequireLogin.Value.ToString().ToLower());
            siteProperties.TryAdd("enableWorkflow", siteRoot.EnableWorkflow.Value.ToString().ToLower());
            siteProperties.TryAdd("browserTitle", siteRoot.BrowserTitle.RawValue);

            //siteProperties.Add("language", "");
            //siteProperties.Add("loginPage", "");


            var site = new Site(siteName, siteProperties);
            this.Sites.Add(siteName, site);
            return site;
        }
    }
}
