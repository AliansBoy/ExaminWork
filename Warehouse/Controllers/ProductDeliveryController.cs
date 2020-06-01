//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Warehouse.Models.Provider;
//using WarehouseDAL;

//namespace Warehouse.Controllers
//{
//    public class ProductDeliveryController : Controller
//    {
//        private WarehouseDbContext db = new WarehouseDbContext();

//        // GET: ProductDelivery
//        public ActionResult Index()
//        {
//            var productDeliveryViewModels = db.ProductDeliveryViewModels.Include(p => p.Delivery).Include(p => p.Product);
//            return View(productDeliveryViewModels.ToList());
//        }

//        // GET: ProductDelivery/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductDeliveryViewModel productDeliveryViewModel = db.ProductDeliveryViewModels.Find(id);
//            if (productDeliveryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productDeliveryViewModel);
//        }

//        // GET: ProductDelivery/Create
//        public ActionResult Create()
//        {
//            ViewBag.DeliveryId = new SelectList(db.DeliveryViewModels, "Id", "Id");
//            ViewBag.ProductId = new SelectList(db.ProductViewModels, "Id", "Manufacturer");
//            return View();
//        }

//        // POST: ProductDelivery/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,ProductId,DeliveryId,Amount")] ProductDeliveryViewModel productDeliveryViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ProductDeliveryViewModels.Add(productDeliveryViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.DeliveryId = new SelectList(db.DeliveryViewModels, "Id", "Id", productDeliveryViewModel.DeliveryId);
//            ViewBag.ProductId = new SelectList(db.ProductViewModels, "Id", "Manufacturer", productDeliveryViewModel.ProductId);
//            return View(productDeliveryViewModel);
//        }

//        // GET: ProductDelivery/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductDeliveryViewModel productDeliveryViewModel = db.ProductDeliveryViewModels.Find(id);
//            if (productDeliveryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.DeliveryId = new SelectList(db.DeliveryViewModels, "Id", "Id", productDeliveryViewModel.DeliveryId);
//            ViewBag.ProductId = new SelectList(db.ProductViewModels, "Id", "Manufacturer", productDeliveryViewModel.ProductId);
//            return View(productDeliveryViewModel);
//        }

//        // POST: ProductDelivery/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,ProductId,DeliveryId,Amount")] ProductDeliveryViewModel productDeliveryViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(productDeliveryViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.DeliveryId = new SelectList(db.DeliveryViewModels, "Id", "Id", productDeliveryViewModel.DeliveryId);
//            ViewBag.ProductId = new SelectList(db.ProductViewModels, "Id", "Manufacturer", productDeliveryViewModel.ProductId);
//            return View(productDeliveryViewModel);
//        }

//        // GET: ProductDelivery/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductDeliveryViewModel productDeliveryViewModel = db.ProductDeliveryViewModels.Find(id);
//            if (productDeliveryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productDeliveryViewModel);
//        }

//        // POST: ProductDelivery/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            ProductDeliveryViewModel productDeliveryViewModel = db.ProductDeliveryViewModels.Find(id);
//            db.ProductDeliveryViewModels.Remove(productDeliveryViewModel);
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
