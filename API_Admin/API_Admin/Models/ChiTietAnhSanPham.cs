using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class ChiTietAnhSanPham
{
    public int MaAnhChiTiet { get; set; }

    public int? MaSanPham { get; set; }

    public string? Anh { get; set; }

    public string? TenAnh { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
