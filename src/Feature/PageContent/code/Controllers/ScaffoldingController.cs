using System.Web.Mvc;
using Sitecore.Feature.PageContent.Models;
using Sitecore.Foundation.Navigation.Models;

namespace Sitecore.Feature.PageContent.Controllers
{
    public class ScaffoldingController : Controller
    {
        public ActionResult Header()
        {
            var model = new HeaderRenderingModel();
            model.SocialLinks = model.RenderingItem.SocialLinks.GetTarget<ILinkMenuItem>();
            model.MainNavigation = model.RenderingItem.PrimaryNavigationLinks.GetTarget<ILinkMenuItem>();
            model.ReferenceLinks = model.RenderingItem.ReferenceLinks.GetTarget<ILinkMenuItem>();

            return this.View(model);
        }
    }
}
