namespace ShopManagerMini.Models;

public class Customer
{
    public string MaKH { get; set; } = string.Empty;
    public string HoTen { get; set; } = string.Empty;
    public string SoDienThoai { get; set; } = string.Empty;
    public string LoaiKH { get; set; } = string.Empty;

    public Customer() { }

    public Customer(string maKH, string hoTen, string soDienThoai, string loaiKH)
    {
        MaKH = maKH;
        HoTen = hoTen;
        SoDienThoai = soDienThoai;
        LoaiKH = loaiKH;
    }
}
