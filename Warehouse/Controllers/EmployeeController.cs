using AutoMapper;
using Common.Enums;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models.Employee;
using WarehouseBL.Interfaces;
using WarehouseBL.Models.Employee;

namespace Warehouse.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [Authorize(Roles = UserRoles.Employee)]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: Employee
        public ActionResult Details()
        {
            var userIdentity = User.Identity.GetUserId();
            var employeeBL = _service.GetById(userIdentity);
            var employee = _mapper.Map<EmployeeViewModel>(employeeBL);

            return View(employee);
        }

        //        // GET: Employee/Details/5
        //        public ActionResult Details(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
        //            if (employeeViewModel == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(employeeViewModel);
        //        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            var model = TempData["NewEmployee"];
            var modelBL = _mapper.Map<EmployeeBL>(model);
            _service.Create(modelBL);
            return RedirectToAction("Index", "Home");
        }

        //        // POST: Employee/Create
        //        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Create([Bind(Include = "Id,UserId,DateBorn,Position,Address")] EmployeeViewModel employeeViewModel)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                db.EmployeeViewModels.Add(employeeViewModel);
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }

        //            return View(employeeViewModel);
        //        }

        //        // GET: Employee/Edit/5
        //        public ActionResult Edit(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
        //            if (employeeViewModel == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(employeeViewModel);
        //        }

        //        // POST: Employee/Edit/5
        //        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Edit([Bind(Include = "Id,UserId,DateBorn,Position,Address")] EmployeeViewModel employeeViewModel)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                db.Entry(employeeViewModel).State = EntityState.Modified;
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }
        //            return View(employeeViewModel);
        //        }

        //        // GET: Employee/Delete/5
        //        public ActionResult Delete(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
        //            if (employeeViewModel == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(employeeViewModel);
        //        }

        //        // POST: Employee/Delete/5
        //        [HttpPost, ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult DeleteConfirmed(int id)
        //        {
        //            EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
        //            db.EmployeeViewModels.Remove(employeeViewModel);
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
