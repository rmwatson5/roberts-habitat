using Sitecore.Foundation.DataAccess.Models;
using Sitecore.Foundation.Navigation.Models;
using Synthesis;

namespace Sitecore.Feature.PageContent.Models
{
    public class HeaderRenderingModel : SynthesisRenderingModel<IStandardTemplateItem, IHeaderSettingsItem>
    {
        public ILinkMenuItem SocialLinks { get; set; }
        public ILinkMenuItem ReferenceLinks { get; set; }
        public ILinkMenuItem MainNavigation { get; set; }
    }
}
