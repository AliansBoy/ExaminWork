using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models.Products;
using WarehouseBL.Interfaces;

namespace Warehouse.Controllers
{
    // GET: Nav
    public class NavController : Controller
    {
        private readonly IProductGroupService _productGroupService;
        private readonly IMapper _mapper;

        public NavController(IProductGroupService productGroupService, IMapper mapper)
        {
            _productGroupService = productGroupService;
            _mapper = mapper;
        }
        // GET: Nav
        public ActionResult Menu()
        {
            var categoriesBL = _productGroupService.GetAll().ToList();
            var categories = _mapper.Map<IEnumerable<ProductGroupViewModel>>(categoriesBL);
            return View(categories);
        }
    }
}