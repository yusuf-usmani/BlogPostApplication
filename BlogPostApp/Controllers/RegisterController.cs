using BLL;
using BOL;
using System;
using System.Web.Mvc;

namespace BlogPostApp.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private IUserBS userBS;
        public RegisterController(IUserBS _userBS)
        {
            userBS = _userBS;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_user user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    user.Role = "E";
                    userBS.Insert(user);
                    TempData["Msg"] = "Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Create Failed : " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}