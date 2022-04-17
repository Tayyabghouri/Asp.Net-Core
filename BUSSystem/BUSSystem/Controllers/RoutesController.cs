using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BUSSystem.Controllers
{
    public class RoutesController : Controller
    {
        // GET: Routes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Routes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Routes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Routes/Create
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

        // GET: Routes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Routes/Edit/5
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

        // GET: Routes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Routes/Delete/5
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
