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
            return View();
        }

        public ActionResult Partial_ItemsByCateId()
        {
            var items = db.tb_Sanpham.Where(x => x.Sp).Take(12).ToList();
            return PartialView(items);
        }
    }
}