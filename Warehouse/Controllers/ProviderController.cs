using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models.Provider;
using WarehouseBL.Interfaces;
using WarehouseBL.Models.Provider;

namespace Warehouse.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProviderService _service;
        private readonly IMapper _mapper;

        public ProviderController(IProviderService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        //        // GET: Provider
        //        public ActionResult Index()
        //        {
        //            return View(db.ProviderViewModels.ToList());
        //        }

        //        // GET: Provider/Details/5
        //        public ActionResult Details(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            ProviderViewModel providerViewModel = db.ProviderViewModels.Find(id);
        //            if (providerViewModel == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(providerViewModel);
        //        }

        // GET: Provider/Create
        public ActionResult Create()
        {
            var model = TempData["NewProvider"];
            var modelBL = _mapper.Map<ProviderBL>(model);
            _service.Create(modelBL);
            return RedirectToAction("Index", "Home");
        }

        //        // POST: Provider/Create
        //        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Create([Bind(Include = "Id,UserId,OrganizationName,Address,ContactPerson,Position")] ProviderViewModel providerViewModel)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                db.ProviderViewModels.Add(providerViewModel);
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }

        //            return View(providerViewModel);
        //        }

        //        // GET: Provider/Edit/5
        //        public ActionResult Edit(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            ProviderViewModel providerViewModel = db.ProviderViewModels.Find(id);
        //            if (providerViewModel == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(providerViewModel);
        //        }

        //        // POST: Provider/Edit/5
        //        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Edit([Bind(Include = "Id,UserId,OrganizationName,Address,ContactPerson,Position")] ProviderViewModel providerViewModel)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                db.Entry(providerViewModel).State = EntityState.Modified;
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }
        //            return View(providerViewModel);
        //        }

        //        // GET: Provider/Delete/5
        //        public ActionResult Delete(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            ProviderViewModel providerViewModel = db.ProviderViewModels.Find(id);
        //            if (providerViewModel == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(providerViewModel);
        //        }

        //        // POST: Provider/Delete/5
        //        [HttpPost, ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult DeleteConfirmed(int id)
        //        {
        //            ProviderViewModel providerViewModel = db.ProviderViewModels.Find(id);
        //            db.ProviderViewModels.Remove(providerViewModel);
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
    }
}
