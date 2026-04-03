using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoLayouts.Pages
{
    public class Bai2Model : PageModel
    {
        public string Message { get; set; }
        public int Age { get; set; }

        public void OnGet()
        {
            Message = "Xin chào!";
            Age = 20;
        }
    }
}