using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WFHDataModel;
using WFHRepository;
using WFHViewModel;

namespace WFH240.Controllers
{
    public class SertifikasiController : Controller
    {
        // GET: Sertifikasi
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult ListSertifikasi(int id)
        {
            
            return PartialView("_ListSertifikasi", SertifikasiRepo.ByBiodataId(id));  // _list nama viewnya,categoryrepo2 objek yg dipanggil untuk  isi list

        }

        public ActionResult AddSertifikasi()
        {
            
            return PartialView("_AddSertifikasi", new SertifikasiViewModel());  //add-view create
        }

        [HttpPost]
        public ActionResult AddSertifikasi(SertifikasiViewModel model)
        {

            if (!string.IsNullOrEmpty(model.until_month) || !string.IsNullOrEmpty(model.until_year))
            {
                if (int.Parse(model.until_year) < int.Parse(model.valid_start_year) || (int.Parse(model.until_year) == int.Parse(model.valid_start_year) && int.Parse(model.until_month) < int.Parse(model.valid_start_month)))
                {
                    return Json(new
                    {
                        success = false,
                        message = "InValid"
                    }, JsonRequestBehavior.AllowGet);
                }
            }

            if (!ModelState.IsValid)
            {
                return Json(new
                {
                    success = false,
                    message = "InValid"
                }, JsonRequestBehavior.AllowGet);
            }

            ResponseResult result = SertifikasiRepo.Update(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult EditSertifikasi(int id)
        {
            return PartialView("_EditSertifikasi", SertifikasiRepo.ById(id)); //ById dibikin di CategoryRepo dulu
        }
        [HttpPost]
        public ActionResult EditSertifikasi(SertifikasiViewModel model)
        {

            if (!string.IsNullOrEmpty(model.until_month) || !string.IsNullOrEmpty(model.until_year))
            {
                if (int.Parse(model.until_year) < int.Parse(model.valid_start_year) || (int.Parse(model.until_year) == int.Parse(model.valid_start_year) && int.Parse(model.until_month) < int.Parse(model.valid_start_month)))
                {
                    return Json(new
                    {
                        success = false,
                        message = "InValid"
                    }, JsonRequestBehavior.AllowGet);
                }
            }

            //if (!ModelState.IsValid)
            //{
            //    return Json(new
            //    {
            //        success = false,
            //        message = "InValid"
            //    }, JsonRequestBehavior.AllowGet);
            //}

            ResponseResult result = SertifikasiRepo.Update(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult DeleteSertifikasi(int id) // post
        {
            return PartialView("_DeleteSertifikasi", SertifikasiRepo.ById(id)); //habis ini di add view
        }

        [HttpPost]
        public ActionResult DeleteSertifikasi(SertifikasiViewModel model)
        {
            ResponseResult result = SertifikasiRepo.Delete(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult IsBerlakuYearValid(string valid_start_year, string valid_start_month, string until_year, string until_month)
        {

            return Json(SertifikasiRepo.ValidationBerlakuYear(valid_start_year, valid_start_month, until_year, until_month), JsonRequestBehavior.AllowGet);
        }
    }
}
