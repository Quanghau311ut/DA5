using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class ChiTietHoaDonXuat
{
    public int MaChiTietHoaDonXuat { get; set; }

    public int? MaHoaDonXuat { get; set; }

    public int? MaSanPham { get; set; }

    public int? SoLuongBan { get; set; }

    public double? GiaBan { get; set; }

    public virtual HoaDonXuat? MaHoaDonXuatNavigation { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
