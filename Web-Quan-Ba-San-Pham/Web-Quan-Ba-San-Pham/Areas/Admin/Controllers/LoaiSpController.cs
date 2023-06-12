using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Quan_Ba_San_Pham.Models.Models1;

namespace Web_Quan_Ba_San_Pham.Areas.Admin.Controllers
{
    public class LoaiSpController : Controller
    {
        private Model1 db = new Model1();
        // GET: Admin/LoaiSp
        public ActionResult Index()
        {
            var items = db.LoaiSps;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(LoaiSp model)
        {
            if (ModelState.IsValid)
            {               
                db.LoaiSps.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var item = db.LoaiSps.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LoaiSp model)
        {
            if (ModelState.IsValid)
            {
                db.LoaiSps.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.LoaiSps.Find(id);
            if (item != null)
            {
                db.LoaiSps.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }
    }
}