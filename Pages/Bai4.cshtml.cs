using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DemoLayouts.Pages
{
    public class Bai4Model : PageModel
    {
        [BindProperty]
        public string Ten { get; set; } = string.Empty;

        [BindProperty]
        public double Diem { get; set; }

        // Dòng 14: Cú pháp Tuple phải có ngoặc (string, double)
        public static List<(string Ten, double Diem)> DanhSach = new List<(string Ten, double Diem)>();

        public void OnGet()
        {
            // Để trống hoặc khởi tạo dữ liệu nếu muốn
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Ten))
            {
                // Dòng 19: Phải có 2 lần ngoặc: Add( (Ten, Diem) )
                DanhSach.Add((Ten, Diem));
            }
        }
    }
}