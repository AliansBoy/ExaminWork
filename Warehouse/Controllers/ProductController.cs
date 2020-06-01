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
//    public class ProductController : Controller
//    {
//        private WarehouseDbContext db = new WarehouseDbContext();

//        // GET: Product
//        public ActionResult Index()
//        {
//            var productViewModels = db.ProductViewModels.Include(p => p.Country).Include(p => p.ProductGroup);
//            return View(productViewModels.ToList());
//        }

//        // GET: Product/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductViewModel productViewModel = db.ProductViewModels.Find(id);
//            if (productViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productViewModel);
//        }

//        // GET: Product/Create
//        public ActionResult Create()
//        {
//            ViewBag.CountryId = new SelectList(db.CountryViewModels, "Id", "Name");
//            ViewBag.ProductGroupId = new SelectList(db.ProductGroupViewModels, "Id", "Name");
//            return View();
//        }

//        // POST: Product/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,Manufacturer,Title,Price,Amount,CountryId,ProductGroupId")] ProductViewModel productViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ProductViewModels.Add(productViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.CountryId = new SelectList(db.CountryViewModels, "Id", "Name", productViewModel.CountryId);
//            ViewBag.ProductGroupId = new SelectList(db.ProductGroupViewModels, "Id", "Name", productViewModel.ProductGroupId);
//            return View(productViewModel);
//        }

//        // GET: Product/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductViewModel productViewModel = db.ProductViewModels.Find(id);
//            if (productViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.CountryId = new SelectList(db.CountryViewModels, "Id", "Name", productViewModel.CountryId);
//            ViewBag.ProductGroupId = new SelectList(db.ProductGroupViewModels, "Id", "Name", productViewModel.ProductGroupId);
//            return View(productViewModel);
//        }

//        // POST: Product/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,Manufacturer,Title,Price,Amount,CountryId,ProductGroupId")] ProductViewModel productViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(productViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.CountryId = new SelectList(db.CountryViewModels, "Id", "Name", productViewModel.CountryId);
//            ViewBag.ProductGroupId = new SelectList(db.ProductGroupViewModels, "Id", "Name", productViewModel.ProductGroupId);
//            return View(productViewModel);
//        }

//        // GET: Product/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ProductViewModel productViewModel = db.ProductViewModels.Find(id);
//            if (productViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(productViewModel);
//        }

//        // POST: Product/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            ProductViewModel productViewModel = db.ProductViewModels.Find(id);
//            db.ProductViewModels.Remove(productViewModel);
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
