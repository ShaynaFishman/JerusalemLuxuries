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
    public class CartdInfoController : Controller
    {
        // GET: CartdInfo
        public ActionResult Index()
        {
            return View();
        }

        // GET: CartdInfo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartdInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartdInfo/Create
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

        // GET: CartdInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartdInfo/Edit/5
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

        // GET: CartdInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartdInfo/Delete/5
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
