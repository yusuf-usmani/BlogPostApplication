using BlogPostApp.ViewModel;
using BOL;
using System;
using System.IO;
using System.Web.Mvc;
using BlogPostApp.Constants;
using BLL;
using System.Linq;

namespace BlogPostApp.Controllers
{
    /// <summary>
    /// Controller to create Post.
    /// </summary>
    public class PostController : Controller
    {
        private IUserBS userBS;
        public PostController(IUserBS _userBS)
        {
            userBS = _userBS;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogViewModel blogViewModel)
        {
            string fileName = Path.GetFileNameWithoutExtension(blogViewModel.Image.FileName);
            string extension = Path.GetExtension(blogViewModel.Image.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            blogViewModel.Path = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            blogViewModel.Image.SaveAs(fileName);
            Blog blog = new Blog
            {
                Content = blogViewModel.Content,
                Title = blogViewModel.Title,
                ImagePath = blogViewModel.Path,
                StatusId = (int)BlogStatus.Draft,
                userId = userBS.GetALL().Where(x => x.Email == User.Identity.Name).FirstOrDefault().userId
            };
            using (BlogPostEntities blogPostEntities = new BlogPostEntities())
            {
                blogPostEntities.Blogs.Add(blog);
                blogPostEntities.SaveChanges();
            }
            return RedirectToAction("Index","ListPost");
        }
    }
}