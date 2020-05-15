using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XPos.Web.Models;

namespace XPos.Web.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _list = new List<Student>()
        {
            new Student()
            {
                Id=1,
                FirstName="Atur",
                LastName="Aritonang",
                Gender="M",
                Age=25,
                Active=true
            },
            new Student()
            {
                Id=2,
                FirstName="Budi",
                LastName="Suwandy",
                Gender = "M",
                Age=55,
                Active=false
            },
            new Student()
            {
                Id=3,
                FirstName="Sunda",
                LastName="Empire",
                Gender="X",
                Age=120,
                Active=false
            }
        };
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Title = "Student";
            ViewBag.Header = "List of Student";
            return View(_list.ToList());
        }

        //Get
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student model)
        {
            int lastId = _list.Max(o => o.Id) + 1;
            model.Id = lastId;
            _list.Add(model);
            return RedirectToAction("Index");
        }

        //Get
        public ActionResult Edit(int id)
        {
            Student student = _list.Where(o => o.Id == id).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student model)
        {
            int idx = _list.FindIndex(o => o.Id == model.Id);
            _list[idx] = model;
            return RedirectToAction("Index");
        }

        //Get
        public ActionResult Details(int id)
        {
            Student student = _list.Where(o => o.Id == id).FirstOrDefault();
            return View(student);
        }

        //Get
        public ActionResult Delete(int id)
        {
            Student student = _list.Where(o => o.Id == id).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(Student model)
        {
            int idx = _list.FindIndex(o => o.Id == model.Id);
            _list.RemoveAt(idx);
            return RedirectToAction("Index");
        }
    }
}