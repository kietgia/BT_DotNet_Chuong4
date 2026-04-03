using Microsoft.AspNetCore.Mvc;
using DemoLayouts.Models;

namespace DemoLayouts.Pages.Shared.Components.ProductList
{
    public class ProductListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(bool sapXepTang = true)
        {
            var products = new List<Product>()
            {
                new Product(){ Id = 1, Name = "Iphone 14 Pro", Price = 1000 },
                new Product(){ Id = 2, Name = "Samsung Galaxy", Price = 500 },
                new Product(){ Id = 3, Name = "Sony Xperia", Price = 800 }
            };

            // Logic sắp xếp của Bài 3
            if (sapXepTang)
                products = products.OrderBy(p => p.Price).ToList();
            else
                products = products.OrderByDescending(p => p.Price).ToList();

            return View(products);
        }
    }
}