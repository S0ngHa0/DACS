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
    }
}