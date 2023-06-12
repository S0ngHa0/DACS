using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Quan_Ba_San_Pham.Models.Models1;

namespace Web_Quan_Ba_San_Pham.Areas.Admin.Controllers
{
    public class SanphamController : Controller
    {
        private Model1 db = new Model1();
        // GET: Admin/Sanpham
        public ActionResult Index(int? page)
        {
            IEnumerable<tb_Sanpham> items = db.tb_Sanpham.OrderByDescending(x => x.Id);
            var pageSize = 5;
            if (page == null)
            {
                page = 1;
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }

        public  ActionResult Add()
        {
            ViewBag.LoaiSp = new SelectList(db.LoaiSps.ToList(), "Id", "Tenloai");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(tb_Sanpham model)
        {
            if (ModelState.IsValid)
            {
                model.Ngaytao = DateTime.Now;
                model.Ngaysua = DateTime.Now;
                db.tb_Sanpham.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiSp = new SelectList(db.LoaiSps.ToList(), "Id", "Tenloai");
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.LoaiSp = new SelectList(db.LoaiSps.ToList(), "Id", "Tenloai");
            var item = db.tb_Sanpham.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tb_Sanpham model)
        {
            if (ModelState.IsValid)
            {
                model.Ngaysua = DateTime.Now;
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiSp = new SelectList(db.LoaiSps.ToList(), "Id", "Tenloai");
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.tb_Sanpham.Find(id);
            if (item != null)
            {              
                db.tb_Sanpham.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}