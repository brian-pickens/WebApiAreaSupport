using System.Web.Mvc;
using WebApiAreaSupport;

namespace WebApiAreaTestApp.Areas.Api_v1
{
    public class WebApiArea1AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Api_v1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapHttpRoute(
                "WebApiArea1_defaultApi",
                "api/v1/{controller}/{id}",
                new { id = UrlParameter.Optional }
            );
        }
    }
}