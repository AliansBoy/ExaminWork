//using AutoMapper;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Warehouse.Models.Products;
//using WarehouseBL.Interfaces;

//namespace Warehouse.Controllers
//{
//    public class CountryController : Controller
//    {
//        private readonly ICountryService _db;
//        private readonly IMapper _mapper;

//        public CountryController(ICountryService service, IMapper mapper)
//        {
//            _db = service;
//            _mapper = mapper;
//        }

//        // GET: Country
//        public ActionResult Index()
//        {
//            return View();
//        }

//        // GET: Country/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            CountryViewModel countryViewModel = db.CountryViewModels.Find(id);
//            if (countryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(countryViewModel);
//        }

//        // GET: Country/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Country/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,Name")] CountryViewModel countryViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.CountryViewModels.Add(countryViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(countryViewModel);
//        }

//        // GET: Country/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            CountryViewModel countryViewModel = db.CountryViewModels.Find(id);
//            if (countryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(countryViewModel);
//        }

//        // POST: Country/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,Name")] CountryViewModel countryViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(countryViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(countryViewModel);
//        }

//        // GET: Country/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            CountryViewModel countryViewModel = db.CountryViewModels.Find(id);
//            if (countryViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(countryViewModel);
//        }

//        // POST: Country/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            CountryViewModel countryViewModel = db.CountryViewModels.Find(id);
//            db.CountryViewModels.Remove(countryViewModel);
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
