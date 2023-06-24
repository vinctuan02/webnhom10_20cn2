using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTour.Models;
using WebTour.Models.EF;
using PagedList;

namespace WebTour.Areas.Admin.Controllers
{
    public class Product1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Product1
        public ActionResult Index( int? page)
        {
            IEnumerable<Product> item = db.Products.OrderByDescending(x => x.Id);
            var pageSize = 10;
            if(page == null) {
                page = 1;
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            item = item.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(item);
        }

        public ActionResult Add() {
            ViewBag.ProductCategory = new SelectList(db.ProductCategories.ToList(), "Id", "Title");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Product model, List<string> Image, List<bool> rDefault) {
            if(ModelState.IsValid) {


                return RedirectToAction("Index");
            }
            ViewBag.ProductCategory = new SelectList(db.ProductCategories.ToList(), "Id", "Title");
            return View(model);
        }
    }
}