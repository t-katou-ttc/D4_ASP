using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic.Controllers
{
    public class BindController : Controller
    {
        // GET: Bind
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase data)
        {
            if (data != null)
            {
                var f = data.FileName;
                var permit = new string[] { ".jpg", ".png", ".gif" };
                if (!permit.Contains(Path.GetExtension(f)))
                {
                    ViewBag.Message = "jpg,png,gif以外のファイルはアップロードできません";
                    return View();
                }
                data.SaveAs(Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(f)));
                ViewBag.Message = f + "アップロードしました";
            }
            else
            {
                ViewBag.Message = "ファイルを指定してください";
            }
            return View();
        }
    }
}