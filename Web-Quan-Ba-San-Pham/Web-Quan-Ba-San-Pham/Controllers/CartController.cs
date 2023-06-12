using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Quan_Ba_San_Pham.Models;
using Web_Quan_Ba_San_Pham.Models.Models1;

namespace Web_Quan_Ba_San_Pham.Controllers
{
    public class CartController : Controller
    {
        private Model1 db = new Model1();
        // GET: Cart
        public ActionResult Index()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart != null && cart.Items.Any())
            {
                ViewBag.CheckCart = cart;
            }
            return View();
        }
        public ActionResult Partial_Item_Cart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart != null && cart.Items.Any())
            {
                return PartialView(cart.Items);
            }
            return PartialView();
        }

        public ActionResult AddToCart(int id, int soluong)
        {
            var code = new { Success = false, msg = "", code = -1, Count = 0 };
            var db = new Model1();
            var checkProduct = db.tb_Sanpham.FirstOrDefault(x => x.Id == id);
            if (checkProduct != null)
            {
                Cart cart = (Cart)Session["Cart"];
                if (cart == null)
                {
                    cart = new Cart();
                }
                CartItem item = new CartItem
                {
                    IdSanpham = checkProduct.Id,
                    Tieude = checkProduct.Tieude,
                    Loaisp = checkProduct.LoaiSp.Tenloai,
                    Hinhanh = checkProduct.Hinhanh,
                    Soluong = soluong
                };
                item.Gia = checkProduct.Gia;
                if (checkProduct.Giamgia > 0)
                {
                    item.Gia = (decimal)checkProduct.Giamgia;
                }
                item.Tongtien = item.Soluong * item.Gia;
                cart.AddToCart(item, soluong);
                Session["Cart"] = cart;
                code = new { Success = true, msg = "Thêm sản phẩm vào giở hàng thành công!", code = 1, Count = cart.Items.Count };
            }
            return Json(code);
        }
    }
}