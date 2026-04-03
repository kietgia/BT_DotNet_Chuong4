using Microsoft.AspNetCore.Mvc;

namespace DemoLayouts.Pages.Shared.Components.BestSellers
{
    public class BestSellersViewComponent : ViewComponent
    {
        // Sử dụng InvokeAsync (Bất đồng bộ) - Cách khuyên dùng
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            // Giả lập danh sách dữ liệu
            var allBestSellers = new List<string> 
            { 
                "Laptop Gaming", "iPhone 15 Pro Max", "Tai nghe Sony", 
                "iPad Air M2", "Apple Watch Ultra", "Loa Marshall" 
            };

            // Giả lập đợi Database 10ms
            await Task.Delay(10);

            // Lấy ra số lượng sản phẩm dựa theo tham số 'count' truyền vào
            var bestSellers = allBestSellers.Take(count).ToList();

            return View(bestSellers);
        }
    }
}