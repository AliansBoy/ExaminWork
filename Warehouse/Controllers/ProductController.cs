//using System;
//using System.Collections.Generic;
using AutoMapper;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models.Products;
using WarehouseBL.Interfaces;
using WarehouseDAL;
using System;
using WarehouseBL.Models.Products;
using Warehouse.HtmlHelpers;
using PagedList;

namespace Warehouse.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICountryService _countryService;
        private readonly IProductGroupService _productGroupService;
        private readonly IMapper _mapper;
        public int PageSize = 4;

        public ProductController(IProductService service, ICountryService countryService,
                                    IProductGroupService productGroupService, IMapper mapper)
        {
            _productService = service;
            _countryService = countryService;
            _productGroupService = productGroupService;
            _mapper = mapper;
        }
        //// GET: Product
        //public ActionResult Index(PagedListHelper filter)
        //{
        //    var productsBL = _productService.GetAll();
        //    var products = _mapper.Map<IEnumerable<ProductViewModel>>(productsBL);

        //    var resultAsPagedList = new StaticPagedList<ProductViewModel>(products, filter.Page, filter.PageSize, 5);

        //    return View(resultAsPagedList);
        //}

        public ViewResult List(int categoryId = 0, int page = 1)
        {
            var productsBL = _productService.Where(categoryId, page, PageSize);
            var products = _mapper.Map<IEnumerable<ProductViewModel>>(productsBL);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = categoryId == 0 ?
                                _productService.GetAll().Count() :
                                _productService.GetAll().Count(e => e.ProductGroup.Id == categoryId)
                },
                CurrentCateogry = categoryId
            };
            return View(model);
        }

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

        // GET: Product/Create
        public ActionResult Create()
        {
            var countryBL = _countryService.GetAll().ToList();
            ViewBag.CountryId = new SelectList(countryBL.Select(x => new { x.Id, Name = $"{x.Name}" }), "Id", "Name");

            var groupBL = _productGroupService.GetAll().ToList();
            ViewBag.ProductGroupId = new SelectList(groupBL.Select(x => new { x.Id, Name = $"{x.Name}" }), "Id", "Name");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productModel)
        {
            if (ModelState.IsValid)
            {
                var fileName = Path.GetFileNameWithoutExtension(productModel.ImageFile.FileName);
                var extension = Path.GetExtension(productModel.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                productModel.Image = "~/Image/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
                productModel.ImageFile.SaveAs(fileName);
                var model = _mapper.Map<ProductBL>(productModel);
                _productService.Create(model);
            }
            ModelState.Clear();
            return RedirectToAction("Index", "Home");
        }

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
    }
}
