using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_net.Controllers
{
    public class ComicController : Controller
    {
        // GET: Comic
        public ActionResult Index()
        {
            return View();
        }
    }
}