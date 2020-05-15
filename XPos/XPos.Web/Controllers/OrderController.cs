using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XPos.DataModel;
using XPos.Repository;

namespace XPos.Web.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductList(string search = "")
        {
            return PartialView("_ProductList", ProductRepo.BySearch(search));
        }

        public ActionResult OrderByProduct(long id)
        {
            return PartialView("_OrderByProduct", ProductRepo.ById(id));
        }

        [HttpPost]
        public ActionResult Payment(OrderHeader model, int type = 0)
        {
            ViewBag.Type = type;
            if (type == 0)
            {
                return PartialView("_Billing", model);
            }
            else
            {
                ResponseResult result = OrderRepo.Insert(model);
                return Json(new
                {
                    success = result.Success,
                    message = result.Message,
                    entity = result.Entity
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
