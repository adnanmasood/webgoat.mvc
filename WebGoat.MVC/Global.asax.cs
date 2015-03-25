using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System;
using WebGoat.MVC.Controllers;

namespace WebGoat.MVC
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            //filters.Add(new RequireHttpsAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new {controller = "Home", action = "Index", id = UrlParameter.Optional} // Parameter defaults
                );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }


        //protected void Application_Error(object sender, EventArgs e)
        //{


        //    Exception exception = Server.GetLastError();

        //    // Log the exception.
        //    //ILogger logger = Container.Resolve<ILogger>();
        //    //logger.Error(exception);

        //    Response.Clear();


        //    HttpException httpException = exception as HttpException;
        //    RouteData routeData = new RouteData();
        //    routeData.Values.Add("controller", "Error");

        //    if (httpException == null)
        //    {
        //        routeData.Values.Add("action", "Index");
        //    }
        //    else //It's an Http Exception, Let's handle it.
        //    {

        //        switch (httpException.GetHttpCode())
        //        {
        //            case 404:
        //                // Page not found.
        //                routeData.Values.Add("action", "HttpError404");
        //                break;
        //            case 500:
        //                // Server error.
        //                routeData.Values.Add("action", "HttpError500");
        //                break;
        //            // Here you can handle Views to other error codes.
        //            // I choose a General error template  
        //            default:
        //                routeData.Values.Add("action", "General");
        //                break;
        //        }
        //    }

        //    // Pass exception details to the target error View.
        //    routeData.Values.Add("error", exception.Message);

        //    // Clear the error on server.
        //    Server.ClearError();

        //    // Call target Controller and pass the routeData.
        //    IController errorController = new ErrorController();
        //    errorController.Execute(new RequestContext(
        //        new HttpContextWrapper(Context), routeData));

        //}
    }
}