using database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace database.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product/Index
        public ActionResult Index()
        {
            using (dbModels 
                = new dbModels())
            {

                return View(dbModel.product.ToList());
            }
            
        }

        // GET: Product/myhomepage
        public ActionResult myhomepage()
        {
            using (dbModels dbModel = new dbModels())
            {

                return View(dbModel.product.ToList());
            }

        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       

        // GET: Product/Create
        public ActionResult Create()
        {

            return View();
                
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(product prod)
        {
            try
            {
                using (dbModels dbModel = new dbModels())
                {
                    dbModel.product.Add(prod);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Product/Index");
            }

            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
