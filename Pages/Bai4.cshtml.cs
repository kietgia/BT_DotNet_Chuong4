using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DemoLayouts.Pages
{
    public class Bai4Model : PageModel
    {
        [BindProperty]
        public string Ten { get; set; }

        [BindProperty]
        public double Diem { get; set; }

        public static List<(string Ten, double Diem)> DanhSach = new List<(string, double)>();

        public void OnPost()
        {
            DanhSach.Add((Ten, Diem));
        }
    }
}