using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JerusalemLuxuryDomain.Models;
using JerusalemLuxuryDomain.DataSource;
using JerusalemLuxuries.Models;


namespace JerusalemLuxuries.Controllers
{
    public class PropertyCategoryController : Controller
    {
        // GET: PropertyCategory
        public ActionResult Index()
        {
            return View();
        }

        // GET: PropertyCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropertyCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyCategory/Create
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

        // GET: PropertyCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PropertyCategory/Edit/5
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

        // GET: PropertyCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PropertyCategory/Delete/5
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
