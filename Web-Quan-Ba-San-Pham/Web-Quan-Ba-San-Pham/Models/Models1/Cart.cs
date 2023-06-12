using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    public class Cart
    {
        public List<CartItem> Items { get; set; }
        public Cart()
        {
            this.Items = new List<CartItem>();
        }

        public void AddToCart(CartItem item, int Quantity)
        {
            var checkExits = Items.FirstOrDefault(x => x.IdSanpham == item.IdSanpham);
            if (checkExits != null)
            {
                checkExits.Soluong += Quantity;
                checkExits.Tongtien = checkExits.Gia * checkExits.Soluong;
            }
            else
            {
                Items.Add(item);
            }
        }

        public void Remove(int id)
        {
            var checkExits = Items.SingleOrDefault(x => x.IdSanpham == id);
            if (checkExits != null)
            {
                Items.Remove(checkExits);
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            var checkExits = Items.SingleOrDefault(x => x.IdSanpham == id);
            if (checkExits != null)
            {
                checkExits.Soluong = quantity;
                checkExits.Tongtien = checkExits.Gia * checkExits.Soluong;
            }
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(x => x.Tongtien);
        }
        public int GetTotalQuantity()
        {
            return Items.Sum(x => x.Soluong);
        }
        public void ClearCart()
        {
            Items.Clear();
        }

    }

    public class CartItem
    {
        public int IdSanpham { get; set; }
        public string Tieude { get; set; }
        public string Loaisp { get; set; }
        public string Hinhanh { get; set; }
        public int Soluong { get; set; }
        public decimal Gia { get; set; }
        public decimal Tongtien { get; set; }
    }
}