using System;
using System.Collections.Generic;

namespace API_Admin.Models;

public partial class Menu
{
    public int MaMenu { get; set; }

    public string? TenMenu { get; set; }

    public string? MoTa { get; set; }

    public bool? TrangThai { get; set; }
}
