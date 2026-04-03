using btdotnet_chuong4.Models; // Sửa ở đây
using Microsoft.AspNetCore.Mvc;

namespace btdotnet_chuong4.Pages.Shared.Components.ProductList // Sửa ở đây
{
    public class ProductListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = new List<Product>() // Đảm bảo chữ Product viết hoa đúng
            {
                new Product(){ Id = 1, Name = "Iphone 14 Pro", Price = 1000 },
                new Product(){ Id = 2, Name = "Samsung Galaxy", Price = 500 },
                new Product(){ Id = 3, Name = "Sony Xperia", Price = 800 }
            };
            return View(products);
        }
    }
}