using BOL;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogPostApp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult SignIn(tbl_user user)
        {
            try
            {
                if (Membership.ValidateUser(user.Email, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.Email, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["Msg"] = "Login Failed";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception Ex)
            {
                TempData["Msg"] = "Login Failed" + Ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}