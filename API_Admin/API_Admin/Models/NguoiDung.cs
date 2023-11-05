using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class NguoiDung
{
    public int ManguoiDung { get; set; }

    public string? HoTen { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? GioiTinh { get; set; }

    public string? AnhDaiDien { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public string? DienThoai { get; set; }

    public bool? TrangThai { get; set; }

    public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; } = new List<HoaDonNhap>();

    public virtual ICollection<HoaDonXuat> HoaDonXuats { get; set; } = new List<HoaDonXuat>();

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
