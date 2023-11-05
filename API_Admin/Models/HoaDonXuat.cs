using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class HoaDonXuat
{
    public int MaHoaDonXuat { get; set; }

    public string? SoHoaDonXuat { get; set; }

    public DateTime? NgayXuat { get; set; }

    public int? MaNguoiDung { get; set; }

    public virtual ICollection<ChiTietHoaDonXuat> ChiTietHoaDonXuats { get; set; } = new List<ChiTietHoaDonXuat>();

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
