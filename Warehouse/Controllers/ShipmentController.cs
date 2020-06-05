//using AutoMapper;
//using Common.Enums;
//using System;
using AutoMapper;
using Common.Enums;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models.Customer;
using WarehouseBL.Interfaces;

namespace Warehouse.Controllers
{
    [Authorize(Roles = UserRoles.Customer)]
    public class ShipmentController : Controller
    {
        private readonly IShipmentService _service;
        private readonly IProductService _product;
        private readonly IMapper _mapper;

        public ShipmentController(IShipmentService service, IProductService product, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            _product = product;
        }

        // GET: Shipment
        public ActionResult Index()
        {
            var shipmentBL = _service.GetAll().ToList();
            var shipment = _mapper.Map<IEnumerable<ShipmentViewModel>>(shipmentBL);

            return View(shipment);
        }

        //public ActionResult AddToDelivery(int id)
        //{
        //    var comicBook = _product.GetById(id);
        //    var cart = _cartService.GetCart(this.HttpContext);
        //    cart.AddToCart(comicBook);

        //    return RedirectToAction("List", "ComicBooks");
        //}
    }
}
