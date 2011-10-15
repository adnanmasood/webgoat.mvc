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
            return View();
        }

        public ActionResult SecurityMisconfiguration3()
        {
            return View();
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

        public ActionResult UnvalidatedRedirectsAndForwards1()
        {
            return View();
        }

        public ActionResult UnvalidatedRedirectsAndForwards2()
        {
            return View();
        }

        #endregion

        #region Fixes

        public ActionResult UnvalidatedRedirectsAndForwardsFix1()
        {
            return View();
        }

        public ActionResult UnvalidatedRedirectsAndForwardsFix2()
        {
            return View();
        }


        #endregion

        #endregion
    }
}
