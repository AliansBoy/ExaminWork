//using AutoMapper;
//using Common.Enums;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Warehouse.Models.Customer;
//using WarehouseBL.Interfaces;

//namespace Warehouse.Controllers
//{
//    [Authorize(Roles = UserRoles.Customer)]
//    public class ShipmentController : Controller
//    {
//        private readonly IShipmentService _service;
//        private readonly IMapper _mapper;

//        public ShipmentController(IShipmentService service, IMapper mapper)
//        {
//            _service = service;
//            _mapper = mapper;
//        }
//        // GET: Shipment
//        public ActionResult Index()
//        {
//            var shipmentBL = _service.GetAll().ToList();
//            var shipment = _mapper.Map<IEnumerable<ShipmentViewModel>>(shipmentBL);

//            return View(shipment);
//        }

//        // GET: Shipment/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            var shipmentBL = _service.GetById(id);
//            var shipment = _mapper.Map<ShipmentViewModel>(shipmentBL);

//            return View(shipment);
//        }

//        // GET: Shipment/Create
//        public ActionResult Create()
//        {
//            ViewBag.CustomerId = new SelectList(db.CustomerViewModels, "Id", "UserId");
//            ViewBag.EmployeeId = new SelectList(db.EmployeeViewModels, "Id", "UserId");
//            return View();
//        }

//        // POST: Shipment/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,CustomerId,EmployeeId,DeliveryDate")] ShipmentViewModel shipmentViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ShipmentViewModels.Add(shipmentViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.CustomerId = new SelectList(db.CustomerViewModels, "Id", "UserId", shipmentViewModel.CustomerId);
//            ViewBag.EmployeeId = new SelectList(db.EmployeeViewModels, "Id", "UserId", shipmentViewModel.EmployeeId);
//            return View(shipmentViewModel);
//        }

//        // GET: Shipment/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ShipmentViewModel shipmentViewModel = db.ShipmentViewModels.Find(id);
//            if (shipmentViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.CustomerId = new SelectList(db.CustomerViewModels, "Id", "UserId", shipmentViewModel.CustomerId);
//            ViewBag.EmployeeId = new SelectList(db.EmployeeViewModels, "Id", "UserId", shipmentViewModel.EmployeeId);
//            return View(shipmentViewModel);
//        }

//        // POST: Shipment/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,CustomerId,EmployeeId,DeliveryDate")] ShipmentViewModel shipmentViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(shipmentViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.CustomerId = new SelectList(db.CustomerViewModels, "Id", "UserId", shipmentViewModel.CustomerId);
//            ViewBag.EmployeeId = new SelectList(db.EmployeeViewModels, "Id", "UserId", shipmentViewModel.EmployeeId);
//            return View(shipmentViewModel);
//        }

//        // GET: Shipment/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ShipmentViewModel shipmentViewModel = db.ShipmentViewModels.Find(id);
//            if (shipmentViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(shipmentViewModel);
//        }

//        // POST: Shipment/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            ShipmentViewModel shipmentViewModel = db.ShipmentViewModels.Find(id);
//            db.ShipmentViewModels.Remove(shipmentViewModel);
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
