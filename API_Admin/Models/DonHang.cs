using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class DonHang
{
    public int MaDonHang { get; set; }

    public DateTime? NgayDat { get; set; }

    public int? TrangThaiDonhang { get; set; }

    public int? MaKhachHang { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual KhachHang? MaKhachHangNavigation { get; set; }
}
