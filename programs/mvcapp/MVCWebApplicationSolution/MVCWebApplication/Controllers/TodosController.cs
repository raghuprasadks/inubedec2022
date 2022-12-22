using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class TodosController : Controller
    {

        static IList<Todos> todosList = new List<Todos>();
        
        // GET: Todos

        public ActionResult Index()
        {
            return View(todosList);
        }

        // GET: Todos/Details/5
        public ActionResult Details(int id)
        {
            Todos details = null;
            foreach (Todos todo in todosList)
            {
                if (todo.Id == id)
                {
                    details = todo;
                }
            }

            return View(details);
        }

        // GET: Todos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todos/Create
        [HttpPost]
        public ActionResult Create(Todos todo)
        // public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                todosList.Add(todo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Todos/Edit/5
        public ActionResult Edit(int id)
        {
            Todos todotoedit = null;
            foreach (Todos todo in todosList)
            {
                if (todo.Id == id)
                {
                    todotoedit = todo;
                }
            }

            return View(todotoedit);
        }

        // POST: Todos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Todos todotoedit)
        {
            try
            {
                // TODO: Add update logic here

                int editindex=-1;
                for (int i=0;i< todosList.Count;i++)
                {
                    if (todosList[i].Id == todotoedit.Id)
                    {
                        todosList[i]= todotoedit;
                    }
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Todos/Delete/5
        public ActionResult Delete(int id)
        {
            Todos todostodel = null;
            foreach (Todos todo in todosList)
            {
                if (todo.Id == id)
                {
                    todostodel = todo;
                }
            }
            return View(todostodel);
        }

        // POST: Todos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Todos todos)
        {
            try
            {
                // TODO: Add delete logic here
                //todosList.Remove(todos);
                //todosList = (todo) => todo.id != id;
                IList<Todos> todosAfterDelete = new List<Todos>();
                for (int i=0;i< todosList.Count; i++)
                {
                    if (todosList[i].Id != todos.Id)
                    {
                        todosAfterDelete.Add(todosList[i]);
                    }
                }
                todosList = todosAfterDelete;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
