using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class ChiTietDonHang
{
    public int MaChiTietDonHang { get; set; }

    public int? MaDonHang { get; set; }

    public int? MaSanPham { get; set; }

    public int? SoLuongDat { get; set; }

    public double? GiaMua { get; set; }

    public virtual DonHang? MaDonHangNavigation { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
