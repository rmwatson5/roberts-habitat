using System.Web.Mvc;
using System.Web.Routing;

namespace Sitecore.Project.Website
{
    public class MvcApplication : Web.Application
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
