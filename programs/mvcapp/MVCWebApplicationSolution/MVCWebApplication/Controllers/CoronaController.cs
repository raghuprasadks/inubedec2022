using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class CoronaController : Controller
    {
        IList<Corona> coronaList = new List<Corona>();

        // GET: Corona
        public ActionResult Index()
        {
            Corona state1 = new Corona();
            state1.Id = 1;
            state1.Name = "Corona";
            state1.Active = 1000;
            state1.Recovered = 2000;
            state1.Death = 100;
            coronaList.Add(state1);

            return View(coronaList);
        }

        // GET: Corona/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Corona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Corona/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Corona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Corona/Edit/5
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

        // GET: Corona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Corona/Delete/5
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
