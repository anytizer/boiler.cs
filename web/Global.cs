using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Optimization;

namespace web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleCollection bundles = new BundleCollection();
            bundles.Add(new ScriptBundle("~/js").IncludeDirectory("~/js", "*.js", true));
            bundles.Add(new StyleBundle("~/css").IncludeDirectory("~/css", "*.css", true));
            //bundles.Add(new StyleBundle("~/css").Include(""));
        }

        protected void Application_BeginRequest()
        {
            bool https = Context.Request.IsSecureConnection;
            string url = Context.Request.Url.ToString();
            string hostname = Context.Request.Url.Host;

            //Response.Redirect("https://www.example.com/");
            //Response.End();
        }

        private bool isMobile()
        {
            HttpBrowserCapabilities browserCapabilities = Request.Browser;
            bool isMobile = browserCapabilities.IsMobileDevice;

            return isMobile;
        }
    }
}