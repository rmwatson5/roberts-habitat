using System.Web.Mvc;
using Newtonsoft.Json.Linq;

namespace Sitecore.Feature.Navigation.Controllers
{
    public class SearchApiController : Controller
    {
        public JObject GetSearchResults()
        {
            return new JObject();
        }
    }
}
