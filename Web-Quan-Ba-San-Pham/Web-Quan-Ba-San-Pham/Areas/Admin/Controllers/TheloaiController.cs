using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Quan_Ba_San_Pham.Models.Models1;

namespace Web_Quan_Ba_San_Pham.Areas.Admin.Controllers
{
    public class TheloaiController : Controller
    {
        private Model1 db = new Model1();
        // GET: Admin/Theloai
        public ActionResult Index()
        {
            var items = db.tb_Theloai;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(tb_Theloai model)
        {
            if (ModelState.IsValid)
            {
                model.Ngaytao = DateTime.Now;
                model.Ngaysua = DateTime.Now;
                db.tb_Theloai.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var item = db.tb_Theloai.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tb_Theloai model)
        {
            if (ModelState.IsValid)
            {
                db.tb_Theloai.Attach(model);
                model.Ngaysua = DateTime.Now;
                db.Entry(model).Property(x => x.Tieude).IsModified = true;
                db.Entry(model).Property(x => x.Mota).IsModified = true;
                db.Entry(model).Property(x => x.Link).IsModified = true;                
                db.Entry(model).Property(x => x.Ngaysua).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.tb_Theloai.Find(id);
            if (item != null)
            {
                //var DeleteItem = db.Categories.Attach(item);
                db.tb_Theloai.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}