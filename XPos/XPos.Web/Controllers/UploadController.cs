using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XPos.DataModel;
using XPos.Repository;

namespace XPos.Web.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult List(int page = 1, int perPage = 8)
        {
            Pagination pg = UploadFileRepo.Paging(page, perPage);
            ViewBag.PageCount = pg.Pages;
            return PartialView("_List", pg.ListOf);
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file, FileCollection model)
        {
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    string[] fileName = file.FileName.Split('.');
                    string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "." + fileName[fileName.Length - 1];
                    string path = Path.Combine(Server.MapPath("~/UploadFiles"), Path.GetFileName(newFileName));
                    file.SaveAs(path);
                    model.FileName = newFileName;
                    ResponseResult result = UploadFileRepo.Update(model);

                    return Json(new
                    {
                        success = result.Success,
                        message = result.Message,
                        entity = result.Entity
                    }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new
                    {
                        success = false,
                        message = ex.Message
                    }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new
                {
                    success = false,
                    message = "You have no specified a file"
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
