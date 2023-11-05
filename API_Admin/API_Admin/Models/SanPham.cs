using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class SanPham
{
    public int MaSanPham { get; set; }

    public int? MaDanhMuc { get; set; }

    public string? TenSanPham { get; set; }

    public string? MoTa { get; set; }

    public string? AnhDaiDien { get; set; }

    public int? MaNhaSanXuat { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? SoLuong { get; set; }

    public int? LuotXem { get; set; }

    public virtual ICollection<ChiTietAnhSanPham> ChiTietAnhSanPhams { get; set; } = new List<ChiTietAnhSanPham>();

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = new List<ChiTietHoaDonNhap>();

    public virtual ICollection<ChiTietHoaDonXuat> ChiTietHoaDonXuats { get; set; } = new List<ChiTietHoaDonXuat>();

    public virtual DanhMuc? MaDanhMucNavigation { get; set; }

    public virtual NhaSanXuat? MaNhaSanXuatNavigation { get; set; }

    public virtual ICollection<ThongSoKyThuat> ThongSoKyThuats { get; set; } = new List<ThongSoKyThuat>();
}
