using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JerusalemLuxuries.Controllers
{
    public class ShortTermCategoryController : Controller
    {
        // GET: ShortTermCategory
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShortTermCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShortTermCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShortTermCategory/Create
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

        // GET: ShortTermCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShortTermCategory/Edit/5
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

        // GET: ShortTermCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShortTermCategory/Delete/5
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
