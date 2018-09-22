using System.Linq;
using System.Web.Mvc;
using Sitecore.Feature.Navigation.Models;

namespace Sitecore.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        public ActionResult LanguageSwitcher()
        {
            var languages = Context.Database.GetLanguages();

            var model = new LanguageSwitcherRenderingModel
            {
                SwitchableLanguages = languages.Select(l => new SwitchableLanguage(l))
            };
            
            return this.View(model);
        }
    }
}
