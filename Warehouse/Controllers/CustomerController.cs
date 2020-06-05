using AutoMapper;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models.Customer;
using WarehouseBL.Interfaces;
using WarehouseBL.Models.Customer;

namespace Warehouse.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET: Customer
        public ActionResult Details()
        {
            var userIdentity = User.Identity.GetUserId();
            var customerBL = _service.GetById(userIdentity);
            var customer = _mapper.Map<CustomerViewModel>(customerBL);

            return View(customer);
        }

        //// GET: Customer/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CustomerViewModel customerViewModel = db.CustomerViewModels.Find(id);
        //    if (customerViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customerViewModel);
        //}

        // GET: Customer/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            var model = TempData["NewCustomer"];
            var modelBL = _mapper.Map<CustomerBL>(model);
            _service.Create(modelBL);
            return RedirectToAction("Index", "Home");
        }

        //// GET: Customer/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CustomerViewModel customerViewModel = db.CustomerViewModels.Find(id);
        //    if (customerViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customerViewModel);
        //}

        //// POST: Customer/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,UserId,IsCanOrder,OrganizationName,Address,ResponsiblePerson,Position")] CustomerViewModel customerViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(customerViewModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(customerViewModel);
        //}

        //// GET: Customer/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CustomerViewModel customerViewModel = db.CustomerViewModels.Find(id);
        //    if (customerViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customerViewModel);
        //}

        //// POST: Customer/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    CustomerViewModel customerViewModel = db.CustomerViewModels.Find(id);
        //    db.CustomerViewModels.Remove(customerViewModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
