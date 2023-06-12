using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Quan_Ba_San_Pham.Models.Models1;

namespace Web_Quan_Ba_San_Pham.Controllers
{
    public class SanPhamController : Controller
    {
        private Model1 db = new Model1();
        // GET: Products
        public ActionResult Index()
        {
            var items = db.tb_Sanpham.ToList();

            return View(items);
        }
        public ActionResult Detail(string alias, int id)
        {
            var item = db.tb_Sanpham.Find(id);
            if (item != null)
            {
                db.tb_Sanpham.Attach(item);
                item.Luotxem = item.Luotxem + 1;
                db.Entry(item).Property(x => x.Luotxem).IsModified = true;
                db.SaveChanges();
            }

            return View(item);
        }
        public ActionResult Partial_ItemsByCateId()
        {
            var items = db.tb_Sanpham.Where(x => x.Sp).Take(12).ToList();
            return PartialView(items);
        }

        public ActionResult ProductCategory(string alias, int id)
        {
            var items = db.tb_Sanpham.ToList();
            if (id > 0)
            {
                items = items.Where(x => x.IdLoaisp == id).ToList();
            }
            var cate = db.LoaiSps.Find(id);
            if (cate != null)
            {
                ViewBag.CateName = cate.Tenloai;
            }

            ViewBag.CateId = id;
            return View(items);
        }
    }
}