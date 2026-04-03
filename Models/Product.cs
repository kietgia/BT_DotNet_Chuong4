namespace btdotnet_chuong4.Models; // Thay DemoLayouts bằng tên thư mục gốc của bạn

public class Product {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
}