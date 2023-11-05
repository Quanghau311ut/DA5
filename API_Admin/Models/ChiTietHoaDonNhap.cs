using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class ChiTietHoaDonNhap
{
    public int MaChiTietHoaDonNhap { get; set; }

    public int? MaHoaDonNhap { get; set; }

    public int? MaSanPham { get; set; }

    public int? SoLuongNhap { get; set; }

    public double? DonGiaNhap { get; set; }

    public virtual HoaDonNhap? MaHoaDonNhapNavigation { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
