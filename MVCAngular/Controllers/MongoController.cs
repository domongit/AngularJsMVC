using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver;
using MVCAngular.Models;
namespace MVCAngular.Controllers
{
    public class MongoController : Controller
    {
        //
        // GET: /Mongo/
        private MongoContext _Context;
         
        public ActionResult Index()
        {
            _Context = new MongoContext();
             var p = new Person() { FirstName = "dom", LastName = "k" };
             var people=  _Context.People.AsQueryable();
            var c =  people.ToList<Person>();

            return View(c);
        }

        //
        // GET: /Mongo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Mongo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Mongo/Create

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

        //
        // GET: /Mongo/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Mongo/Edit/5

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

        //
        // GET: /Mongo/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Mongo/Delete/5

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
