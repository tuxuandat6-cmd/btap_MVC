using Microsoft.AspNetCore.Mvc;
using mvc_02.Models;
using System.Diagnostics;

namespace mvc_02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ProductList()
        {
            // Khởi tạo danh sách sản phẩm mẫu
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop Dell XPS", Price = 25000000 },
                new Product { Id = 2, Name = "iPhone 15 Pro", Price = 28000000 },
                new Product { Id = 3, Name = "Tai nghe Sony WH-1000XM5", Price = 8000000 },
                new Product { Id = 4, Name = "Bàn phím cơ Logi", Price = 3200000 }
            };

            // Truyền danh sách sản phẩm sang View
            return View(products);
        }
    }
}
