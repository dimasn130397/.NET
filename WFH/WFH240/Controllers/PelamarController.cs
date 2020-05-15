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
        public class PelamarController : Controller
        {
            // GET: Pelamar
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult IndexDetail(long id)
            {
                Session["DetailPelamar"] = id;
                return PartialView("_IndexDetail", PelamarRepo.ById(id));
        }
           

        public ActionResult PelamarList(string search = "", int desc = 0, int page = 0, int dataPerPage = 5)
            {
                List<PelamarViewModel> result = PelamarRepo.GetBySearch(search, desc, page, dataPerPage);
                return PartialView("_PelamarList", result);
            }

        //public ActionResult GetAll()
        //{
        //    PelamarRepo biodataRepo = new PelamarRepo();
        //    List<x_biodata> ListBiodata = biodataRepo.GetAll();
        //    return Json(ListBiodata, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult DetailPelamar()
        //{
        //    return PartialView("_IndexDetail");
        //}

        //public ActionResult Search(string search)
        //{
        //    PelamarRepo biodataRepo = new PelamarRepo();
        //    List<x_biodata> SearchBiodata = biodataRepo.Search(search);
        //    if (SearchBiodata.Count == 0 || SearchBiodata == null)
        //    {
        //        SearchBiodata.Add(new x_biodata { fullname = "KOSONG" });
        //        return Json(SearchBiodata, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {

        //        return Json(SearchBiodata, JsonRequestBehavior.AllowGet);
        //    }
        //}

        //public ActionResult OrderBy(string search)
        //{
        //    PelamarRepo biodataRepo = new PelamarRepo();
        //    List<x_biodata> OrderBiodata = biodataRepo.OrderBy(search);
        //    return Json(OrderBiodata, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult OrderByDesc(string search)
        //{
        //    PelamarRepo biodataRepo = new PelamarRepo();
        //    List<x_biodata> OrderBiodata = biodataRepo.OrderByDesc(search);
        //    return Json(OrderBiodata, JsonRequestBehavior.AllowGet);
        //}
    }
    }
