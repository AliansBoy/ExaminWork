using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models.Cart;
using Warehouse.Models.Customer;
using Warehouse.Models.Products;
using WarehouseBL.Interfaces;

namespace Warehouse.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CartController(IProductService product, IMapper mapper)
        {
            _productService = product;
            _mapper = mapper;
        }
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int Id, string returnUrl)
        {
            var product = _productService.GetById(Id);

            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int? Id, string returnUrl)
        {
            var product = _productService.GetById(Id);

            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        public ViewResult Checkout()
        {
            return View(new ShipmentViewModel());
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, ShipmentViewModel shipment)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                //orderProcessor.ProcessOrder(cart, shipment);
                //cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shipment);
            }
        }
    }
}
