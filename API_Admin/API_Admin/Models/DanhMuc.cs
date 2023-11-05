using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class DanhMuc
{
    public int MaDanhMuc { get; set; }

    public string? TenDanhMuc { get; set; }

    public bool? TrangThai { get; set; }

    public int? Stt { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
