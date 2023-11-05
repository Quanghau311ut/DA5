using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class NhaSanXuat
{
    public int MaNhaSanXuat { get; set; }

    public string? TenNhaSanXuat { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
