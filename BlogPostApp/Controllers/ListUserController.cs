using BLL;
using System.Web.Mvc;

namespace BlogPostApp.Controllers
{
    [Authorize(Roles = "A")]
    public class ListUserController : Controller
    {
        private IUserBS userBS;
        public ListUserController(IUserBS _userBS)
        {
            userBS = _userBS;
        }
        // GET: ListUser
        public ActionResult Index()
        {
            var users = userBS.GetALL();
            return View(users);
        }
    }
}