using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JerusalemLuxuries.Controllers
{
    public class PosterController : Controller
    {
        // GET: Poster
        
        public ActionResult Index()
        {
            return View();
        }

        // GET: Poster/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Poster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Poster/Create
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

        // GET: Poster/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Poster/Edit/5
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

        // GET: Poster/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Poster/Delete/5
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
