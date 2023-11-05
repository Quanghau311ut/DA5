using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class TaiKhoan
{
    public int MaTaiKhoan { get; set; }

    public int? MaNguoiDung { get; set; }

    public string? TenDangNhap { get; set; }

    public string? MatKhau { get; set; }

    public bool? TrangThai { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
