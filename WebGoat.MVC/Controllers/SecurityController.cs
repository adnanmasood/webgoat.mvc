/******************************************************************
 * King Wilder - WebGoat.Mvc - port of the Webgoat Java sample app
 * http://github.com/adnanmasood/webgoat.mvc
 * 
 * This controller demonstrates the OWASP exploits 6 - 10.
 * ***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGoat.MVC.Code;
using WebGoat.MVC.Models;
using System.IO;
using System.Net;

namespace WebGoat.MVC.Controllers
{

    public class SecurityController : BaseController
    {

        #region #6 - Security Misconfiguration

        #region Exploit Examples
        public ActionResult SecurityMisconfiguration1()
        {
            return View();
        }

        public ActionResult SecurityMisconfiguration2()
        {
            throw new Exception("Exception thrown by King.");

            return View();
        }

        public ActionResult SecurityMisconfiguration3()
        {
            //throw new FileNotFoundException();

            return View("Bells");
        }

        public ActionResult SecurityMisconfiguration4()
        {
            return View();
        } 
        #endregion

        #region Fixes
        public ActionResult SecurityMisconfigurationFix1()
        {
            return View();
        }

        public ActionResult SecurityMisconfigurationFix2()
        {
            return View();
        }

        public ActionResult SecurityMisconfigurationFix3()
        {
            return View();
        }

        public ActionResult SecurityMisconfigurationFix4()
        {
            return View();
        } 
        #endregion

        #endregion

        #region #7 - Insecure Cryptographic Storage

        #region Exploit Examples
        public ActionResult InsecureCryptographicStorage1()
        {
            
            return View();
        }

        public ActionResult InsecureCryptographicStorage2()
        {
            return View();
        }

        public ActionResult InsecureCryptographicStorage3()
        {
            return View();
        } 
        #endregion

        #region Fixes
        public ActionResult InsecureCryptographicStorageFix1()
        {
            return View();
        }

        public ActionResult InsecureCryptographicStorageFix2()
        {
            return View();
        }

        public ActionResult InsecureCryptographicStorageFix3()
        {
            return View();
        } 
        #endregion

        #endregion

        #region #8 - Failure to Restrict URL Access

        #region Exploit Examples

        public ActionResult FailureToRestrictURLAccess1()
        {
            return View();
        }

        #endregion

        #region Fixes

        public ActionResult FailureToRestrictURLAccessFix1()
        {
            return View();
        }


        #endregion

        #endregion

        #region #9 - Insufficient Transport Layer Protection

        #region Exploit Examples

        public ActionResult InsufficientTransportLayerProtection1()
        {
            return View();
        }

        public ActionResult InsufficientTransportLayerProtection2()
        {
            return View();
        }

        public ActionResult InsufficientTransportLayerProtection3()
        {
            return View();
        }

        #endregion

        #region Fixes

        public ActionResult InsufficientTransportLayerProtectionFix1()
        {
            return View();
        }

        public ActionResult InsufficientTransportLayerProtectionFix2()
        {
            return View();
        }

        public ActionResult InsufficientTransportLayerProtectionFix3()
        {
            return View();
        }


        #endregion

        #endregion

        #region #10 - Unvalidated Redirects and Forwards

        #region Exploit Examples

        /// <summary>
        /// This example points to the Redirect action.
        /// </summary>
        /// <returns></returns>
        [ActionName("redirect1")]
        public ActionResult UnvalidatedRedirectsAndForwards1()
        {
            return View();
        }

        /// <summary>
        /// This example points to the redirect action that validates
        /// the incoming url to a whitelist.
        /// </summary>
        /// <returns></returns>
        [ActionName("redirect2")]
        public ActionResult UnvalidatedRedirectsAndForwards2()
        {
            return View();
        }

        /// <summary>
        /// Action methods should NOT contain a "Redirect" ActionResult
        /// unless it is whitelisted first.
        /// </summary>
        /// <returns></returns>
        public ActionResult Redirect()
        {
            string url = Request.QueryString["url"];
            if (!url.StartsWith("http://"))
            {
                url = "http://" + url;
            }
            
            return Redirect(url);
        }



        #endregion

        #region Fixes

        /// <summary>
        /// This points to Redirect1Fix action.
        /// </summary>
        /// <returns></returns>
        public ActionResult UnvalidatedRedirectsAndForwardsFix1()
        {

            return View();
        }

        /// <summary>
        /// This points to RedirectToWhiteList action.
        /// </summary>
        /// <returns></returns>
        public ActionResult UnvalidatedRedirectsAndForwardsFix2()
        {
            return View();
        }

        /// <summary>
        /// Always make sure the URL belongs to this domain.  When the 
        /// url is found to not be local, we will be redirected to the 
        /// IncorrectURL action.
        /// </summary>
        /// <returns></returns>
        public ActionResult Redirect1Fix()
        {
            string url = Request.QueryString["url"];
            if (!url.StartsWith("http://"))
            {
                url = "http://" + url;
            }
            if (!Url.IsLocalUrl(url))
            {
                return RedirectToAction("IncorrectURL");
            }
            return View();
        }

        /// <summary>
        /// The link on this view will generate an error if the url query string
        /// is not contained within the xml whitelist file.  When the error occurs
        /// it will redirect to the WhiteListError action.
        /// </summary>
        /// <returns></returns>
        public ActionResult RedirectToWhiteList()
        {
            string code = Request.QueryString["code"];
            string url = string.Empty;

            XmlManager xmlManager = new XmlManager(Server.MapPath("~/xml/whitelist.xml"));
            try
            {
                url = xmlManager.GetWhiteList(code);
            }
            catch (NullReferenceException)
            {
                return RedirectToAction("WhiteListError");
            }

            if (!url.StartsWith("http://"))
            {
                url = "http://" + url;
            }
            
            return Redirect(url);
        }

        public ActionResult IncorrectURL()
        {
            return View();
        }

        public ActionResult WhiteListError()
        {
            return View();
        }

        #endregion

        #endregion
    }
}
