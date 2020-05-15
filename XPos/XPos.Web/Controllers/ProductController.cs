using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XPos.DataModel;
using XPos.Repository;

namespace XPos.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<Product> list = ProductRepo.All();
            return PartialView("_List", list);
        }
        public ActionResult Create()
        {
            ViewBag.CategoryList = new SelectList(CategoryRepo.All(), "Id", "Initial");
            ViewBag.VariantList = new SelectList(VariantRepo.ByCategory(-1), "Id", "Initial");
            return PartialView("_Create");
        }
        [HttpPost]
        public ActionResult Create(Product model)
        {
            ResponseResult result = ProductRepo.Update(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Edit(long id)
        {
            Product model = ProductRepo.ById(id);
            ViewBag.CategoryList = new SelectList(CategoryRepo.All(), "Id", "Initial");
            ViewBag.VariantList = new SelectList(VariantRepo.ByCategory(model.Variant.CategoryId), "Id", "Initial");
            return PartialView("_Edit", model);
        }

        [HttpPost]
        public ActionResult Edit(Product model)
        {
            ResponseResult result = ProductRepo.Update(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);
        }

    }
}