//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Warehouse.Models.Products;
//using WarehouseDAL;

//namespace Warehouse.Controllers
//{
//    public class ProductGroupController : Controller
//    {
//        private WarehouseDbContext db = new WarehouseDbContext();

//        // GET: ProductGroup
//        public ActionResult Index()
//        {
//            return View(db.ProductGroupViewModels.ToList());
//        }

//        // GET: ProductGroup/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductGroupViewModel productGroupViewModel = db.ProductGroupViewModels.Find(id);
//            if (productGroupViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productGroupViewModel);
//        }

//        // GET: ProductGroup/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ProductGroup/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,Name,Descriprion")] ProductGroupViewModel productGroupViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ProductGroupViewModels.Add(productGroupViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(productGroupViewModel);
//        }

//        // GET: ProductGroup/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductGroupViewModel productGroupViewModel = db.ProductGroupViewModels.Find(id);
//            if (productGroupViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productGroupViewModel);
//        }

//        // POST: ProductGroup/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,Name,Descriprion")] ProductGroupViewModel productGroupViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(productGroupViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(productGroupViewModel);
//        }

//        // GET: ProductGroup/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductGroupViewModel productGroupViewModel = db.ProductGroupViewModels.Find(id);
//            if (productGroupViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productGroupViewModel);
//        }

//        // POST: ProductGroup/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            ProductGroupViewModel productGroupViewModel = db.ProductGroupViewModels.Find(id);
//            db.ProductGroupViewModels.Remove(productGroupViewModel);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
