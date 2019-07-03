using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic.Models;
using System.Diagnostics;

namespace MvcBasic.Controllers
{
    public class BeginController : Controller
    {
        // GET: Begin
        public ActionResult Index()
        {
            return Content("こんにちは、世界！");
        }
        public ActionResult Show()
        {
            ViewBag.Message = ("こんにちは、世界！");
            return View();
        }

        private MvcBasicContext db = new MvcBasicContext();
        public ActionResult List()
        {
            return View(db.Members);
        }
        public BeginController()
        {
            db.Database.Log = sql =>
            {
                Debug.Write(sql);
            };
        }
    }
}