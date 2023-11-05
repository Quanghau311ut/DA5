using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class HoaDonNhap
{
    public int MaHoaDonNhap { get; set; }

    public string? SoHoaDonNhap { get; set; }

    public DateTime? NgayNhap { get; set; }

    public int? MaNguoiDung { get; set; }

    public int? MaNhaCungCap { get; set; }

    public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = new List<ChiTietHoaDonNhap>();

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }

    public virtual NhaCungCap? MaNhaCungCapNavigation { get; set; }
}
