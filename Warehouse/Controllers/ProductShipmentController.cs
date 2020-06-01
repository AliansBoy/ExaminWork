//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Warehouse.Models.Customer;

//namespace Warehouse.Controllers
//{
//    public class ProductShipmentController : Controller
//    {


//        // GET: ProductShipment
//        public ActionResult Index()
//        {
//            var productShipmentViewModels = db.ProductShipmentViewModels.Include(p => p.Product);
//            return View(productShipmentViewModels.ToList());
//        }

//        // GET: ProductShipment/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductShipmentViewModel productShipmentViewModel = db.ProductShipmentViewModels.Find(id);
//            if (productShipmentViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productShipmentViewModel);
//        }

//        // GET: ProductShipment/Create
//        public ActionResult Create()
//        {
//            ViewBag.ProductId = new SelectList(db.ProductViewModels, "Id", "Manufacturer");
//            return View();
//        }

//        // POST: ProductShipment/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,ProductId,DeliveryId,Amount,UnitPrice,TotalPrice")] ProductShipmentViewModel productShipmentViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ProductShipmentViewModels.Add(productShipmentViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.ProductId = new SelectList(db.ProductViewModels, "Id", "Manufacturer", productShipmentViewModel.ProductId);
//            return View(productShipmentViewModel);
//        }

//        // GET: ProductShipment/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductShipmentViewModel productShipmentViewModel = db.ProductShipmentViewModels.Find(id);
//            if (productShipmentViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.ProductId = new SelectList(db.ProductViewModels, "Id", "Manufacturer", productShipmentViewModel.ProductId);
//            return View(productShipmentViewModel);
//        }

//        // POST: ProductShipment/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,ProductId,DeliveryId,Amount,UnitPrice,TotalPrice")] ProductShipmentViewModel productShipmentViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(productShipmentViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.ProductId = new SelectList(db.ProductViewModels, "Id", "Manufacturer", productShipmentViewModel.ProductId);
//            return View(productShipmentViewModel);
//        }

//        // GET: ProductShipment/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductShipmentViewModel productShipmentViewModel = db.ProductShipmentViewModels.Find(id);
//            if (productShipmentViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productShipmentViewModel);
//        }

//        // POST: ProductShipment/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            ProductShipmentViewModel productShipmentViewModel = db.ProductShipmentViewModels.Find(id);
//            db.ProductShipmentViewModels.Remove(productShipmentViewModel);
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
