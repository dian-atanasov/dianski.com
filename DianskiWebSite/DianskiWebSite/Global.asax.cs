using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace DianskiWebSite
{
    public class Global : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Home", "Home", "~/Home.aspx");
            routes.MapPageRoute("MyResume", "MyResume", "~/Resume.aspx");
            routes.MapPageRoute("MyPortfolio", "MyPortfolio", "~/Portfolio.aspx");
            routes.MapPageRoute("MyHobies", "MyHobies", "~/Hobies.aspx");
            routes.MapPageRoute("MyGallery", "MyGallery", "~/Gallery.aspx");
            routes.MapPageRoute("Contact", "Contact", "~/ContactMe.aspx");
            //routes.MapPageRoute("Usefully", "Usefully", "~/Usefully.aspx");
        }


        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}