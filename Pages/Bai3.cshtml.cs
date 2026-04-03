using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoLayouts.Pages
{
    public class Bai3Model : PageModel
    {
        [BindProperty]
        public string Ten { get; set; }

        [BindProperty]
        public int NamSinh { get; set; }

        public int Tuoi { get; set; }

        public void OnPost()
        {
            Tuoi = 2026 - NamSinh;
        }
    }
}