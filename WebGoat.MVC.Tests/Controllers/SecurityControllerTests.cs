using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MvcContrib.TestHelper;

namespace WebGoat.MVC.Tests.Controllers
{
    [TestClass]
    public class SecurityControllerTests
    {
        [TestInitialize]
        public void Init()
        {
            RouteTable.Routes.Clear();
            WebGoat.MVC.MvcApplication.RegisterRoutes(RouteTable.Routes);
        }

        [TestMethod]
        public void security_redirect1_calls_UnvalidatedRedirectsAndForwards1_action()
        {
            "~/Security/redirect1".ShouldMapTo<WebGoat.MVC.Controllers.SecurityController>(r => r.UnvalidatedRedirectsAndForwards1());
        }

        [TestMethod]
        public void MyTestMethod()
        {
            
        }
    }
}
