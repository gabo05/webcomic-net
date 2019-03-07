using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicXKCD.Api;

namespace ComicXKCD.Web.Controllers
{
    public class ComicController : Controller
    {
        // GET: Comic
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Today()
        {
            return Json(ComicApi.GetTodayComic(), JsonRequestBehavior.AllowGet);
        }
    }
}