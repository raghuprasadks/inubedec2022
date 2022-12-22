using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class HospitalController : Controller
    {

        static IList<Hospital> hospitalList = new List<Hospital>{
                new Hospital() {Id = 1, Name = "Manipal", Location = "Bengaluru" } ,
                new Hospital() { Id = 1, Name = "Aster", Location = "Mysore"  } };


        // GET: Hospital
        public ActionResult Index()
        {
            /**
            Hospital hospital1 = new Hospital();
            hospital1.Id = 1;
            hospital1.Name = "Manipal Hospital";
            hospital1.Location = "Bengaluru";
            hospitalList.Add(hospital1);
    
            if (ViewData["hospitalList"] == null)
            {
                ViewData["hospitalList"] = hospitalList;

            }
            else
            {
                hospitalList = (IList<Hospital>)ViewData["hospitalList"];
            }
    **/
            return View(hospitalList);
        }

        // GET: Hospital/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hospital/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospital/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name,Location")] Hospital hospital)
        {
            try
            {
                // TODO: Add insert logic here
                // int id = (int)collection["Id"];
               // hospital.Id = 1;
                hospitalList.Add(hospital);
              //  ViewData["hospitalList"] = hospitalList;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hospital/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hospital/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hospital/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hospital/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
