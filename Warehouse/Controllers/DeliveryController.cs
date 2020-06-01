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
//    public class DeliveryController : Controller
//    {
//        private WarehouseDbContext db = new WarehouseDbContext();

//        // GET: Delivery
//        public ActionResult Index()
//        {
//            var deliveryViewModels = db.DeliveryViewModels.Include(d => d.Employee).Include(d => d.Provider);
//            return View(deliveryViewModels.ToList());
//        }

//        // GET: Delivery/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DeliveryViewModel deliveryViewModel = db.DeliveryViewModels.Find(id);
//            if (deliveryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(deliveryViewModel);
//        }

//        // GET: Delivery/Create
//        public ActionResult Create()
//        {
//            ViewBag.EmployeeId = new SelectList(db.EmployeeViewModels, "Id", "UserId");
//            ViewBag.ProviderId = new SelectList(db.ProviderViewModels, "Id", "UserId");
//            return View();
//        }

//        // POST: Delivery/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,ProviderId,EmployeeId,DeliveryDate")] DeliveryViewModel deliveryViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.DeliveryViewModels.Add(deliveryViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.EmployeeId = new SelectList(db.EmployeeViewModels, "Id", "UserId", deliveryViewModel.EmployeeId);
//            ViewBag.ProviderId = new SelectList(db.ProviderViewModels, "Id", "UserId", deliveryViewModel.ProviderId);
//            return View(deliveryViewModel);
//        }

//        // GET: Delivery/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DeliveryViewModel deliveryViewModel = db.DeliveryViewModels.Find(id);
//            if (deliveryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.EmployeeId = new SelectList(db.EmployeeViewModels, "Id", "UserId", deliveryViewModel.EmployeeId);
//            ViewBag.ProviderId = new SelectList(db.ProviderViewModels, "Id", "UserId", deliveryViewModel.ProviderId);
//            return View(deliveryViewModel);
//        }

//        // POST: Delivery/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,ProviderId,EmployeeId,DeliveryDate")] DeliveryViewModel deliveryViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(deliveryViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.EmployeeId = new SelectList(db.EmployeeViewModels, "Id", "UserId", deliveryViewModel.EmployeeId);
//            ViewBag.ProviderId = new SelectList(db.ProviderViewModels, "Id", "UserId", deliveryViewModel.ProviderId);
//            return View(deliveryViewModel);
//        }

//        // GET: Delivery/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DeliveryViewModel deliveryViewModel = db.DeliveryViewModels.Find(id);
//            if (deliveryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(deliveryViewModel);
//        }

//        // POST: Delivery/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            DeliveryViewModel deliveryViewModel = db.DeliveryViewModels.Find(id);
//            db.DeliveryViewModels.Remove(deliveryViewModel);
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
