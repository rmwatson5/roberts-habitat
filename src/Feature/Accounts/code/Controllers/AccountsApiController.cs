using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Sitecore.Foundation.Accounts.Models;

namespace Sitecore.Foundation.Accounts.Controllers
{
    public class AccountsApiController : Controller
    {
        public JObject Login(string username, string password)
        {
            var response = new LoginResponse();
            return JObject.FromObject(response);
        }
    }
}
