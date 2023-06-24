﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTour.Models;
using WebTour.Models.EF;

namespace WebTour.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = db.Categories;
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if (ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.ModifierDate = DateTime.Now;
                model.Alias = WebTour.Models.Commons.Filter.FilterChar(model.Title);
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id) {
            var item = db.Categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Attach(model);
                model.ModifierDate = DateTime.Now;
                model.Alias = WebTour.Models.Commons.Filter.FilterChar(model.Title);
                db.Entry(model).Property(x=>x.Title).IsModified = true;
                db.Entry(model).Property(x=>x.Description).IsModified = true;
                db.Entry(model).Property(x=>x.Alias).IsModified = true;
                db.Entry(model).Property(x=>x.Position).IsModified = true;
                db.Entry(model).Property(x=>x.ModifierDate).IsModified = true;
                db.Entry(model).Property(x=>x.ModifierBy).IsModified = true;
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Categories.SingleOrDefault(c => c.Id == id);
            if (item != null)
            {
                db.Entry(item).State = EntityState.Deleted;
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new {success = false});
        }

    }
}