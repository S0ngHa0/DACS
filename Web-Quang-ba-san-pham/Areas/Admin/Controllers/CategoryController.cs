using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Quang_ba_san_pham.Models;

namespace Web_Quang_ba_san_pham.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private Model1 db = new Model1();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = db.Categories;
            return View(items);
        }
        public ActionResult add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult add(Category model)
        {
            if(ModelState.IsValid)
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public ActionResult edit(int CategoryID)
        {
            var item = db.Categories.Find(CategoryID);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult edit(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Attach(model);
                db.Entry(model).Property(x => x.CategoryName).IsModified= true;
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult delete(int CategoryID)
        {
            var item = db.Categories.Find(CategoryID);
            if(item!= null)
            {
                //var deleteItem = db.Categories.Attach(item);
                db.Categories.Remove(item);
                db.SaveChanges();
                return Json(new { success=true });
            }
            return Json(new { success=false });
        }
    }
}