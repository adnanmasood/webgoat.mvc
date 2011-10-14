using System;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace WebGoat.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to WebGoat.MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        [ActionName("injection")]
        public ActionResult Injection()
        {
            return View("Injection");
        }


        [HttpPost]
        [ActionName("injection")]
        public ActionResult Injection(string srchString)
        {
            string msg = "Hello from injection method";

            string connectionString =
                "Data Source=(local);Initial Catalog=Northwind;"
                + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT ProductID, UnitPrice, ProductName from dbo.products "
                + "WHERE UnitPrice > @pricePoint "
                + "ORDER BY UnitPrice DESC;";

            // Specify the parameter value.
            int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (var connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        msg += string.Format("\t{0}\t{1}\t{2}",
                                             reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    msg += (ex.Message);
                }
            }
            return View("Injection");
        }

        [ActionName("xss")]
        public ActionResult CrossSiteScripting()
        {
            return View("About");
        }

        [ActionName("broken-auth")]
        public ActionResult BrokenAuth()
        {
            return View("About");
        }

        [ActionName("insecure-reference")]
        public ActionResult InsecureReference()
        {
            return View("About");
        }

        [ActionName("csrf")]
        public ActionResult CrossSiteRequestForgery()
        {
            return View("About");
        }

        [ActionName("security-misconfig")]
        public ActionResult SecurityMisconfiguration()
        {
            return View("About");
        }

        [ActionName("insecure-crypto-storage")]
        public ActionResult InsecureCryptoStorage()
        {
            return View("About");
        }

        [ActionName("access-failure")]
        public ActionResult AccessFailure()
        {
            return View("About");
        }

        [ActionName("transport-layer")]
        public ActionResult TransportLayer()
        {
            return View("About");
        }

        [ActionName("invalid-forward")]
        public ActionResult InvalidForward()
        {
            return View("About");
        }
    }
}