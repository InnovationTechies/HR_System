using HR_System.Models;
using HR_System.Models.HR_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR_System.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            JobsContext jobsContext = new JobsContext();

            IEnumerable<Article> art= jobsContext.Ariticles.ToList();

            return View(art);
        }
    }
}