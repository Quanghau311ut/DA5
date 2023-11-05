using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_Admin.Models;

public partial class QlchXeMayVietTrungContext : DbContext
{
    public QlchXeMayVietTrungContext()
    {
    }

    public QlchXeMayVietTrungContext(DbContextOptions<QlchXeMayVietTrungContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietAnhSanPham> ChiTietAnhSanPhams { get; set; }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }

    public virtual DbSet<ChiTietHoaDonXuat> ChiTietHoaDonXuats { get; set; }

    public virtual DbSet<DanhMuc> DanhMucs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; }

    public virtual DbSet<HoaDonXuat> HoaDonXuats { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Slide> Slides { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<ThongSoKyThuat> ThongSoKyThuats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TRAN-QUANG-HAU\\SQLEXPRESS;Database=QLCH_XeMayVietTrung;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietAnhSanPham>(entity =>
        {
            entity.HasKey(e => e.MaAnhChiTiet).HasName("PK__ChiTietA__F601A48695C8C937");

            entity.ToTable("ChiTietAnhSanPham");

            entity.Property(e => e.TenAnh).HasMaxLength(250);

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietAnhSanPhams)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__ChiTietAn__MaSan__48CFD27E");
        });

        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => e.MaChiTietDonHang).HasName("PK__ChiTietD__4B0B45DD99FEFA95");

            entity.ToTable("ChiTietDonHang");

            entity.HasOne(d => d.MaDonHangNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaDonHang)
                .HasConstraintName("FK__ChiTietDo__MaDon__5BE2A6F2");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__ChiTietDo__MaSan__5CD6CB2B");
        });

        modelBuilder.Entity<ChiTietHoaDonNhap>(entity =>
        {
            entity.HasKey(e => e.MaChiTietHoaDonNhap).HasName("PK__ChiTietH__7801869A951BCEE7");

            entity.ToTable("ChiTietHoaDonNhap");

            entity.HasOne(d => d.MaHoaDonNhapNavigation).WithMany(p => p.ChiTietHoaDonNhaps)
                .HasForeignKey(d => d.MaHoaDonNhap)
                .HasConstraintName("FK__ChiTietHo__MaHoa__534D60F1");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietHoaDonNhaps)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__ChiTietHo__MaSan__5441852A");
        });

        modelBuilder.Entity<ChiTietHoaDonXuat>(entity =>
        {
            entity.HasKey(e => e.MaChiTietHoaDonXuat).HasName("PK__ChiTietH__0742A74E812F9FA0");

            entity.ToTable("ChiTietHoaDonXuat");

            entity.HasOne(d => d.MaHoaDonXuatNavigation).WithMany(p => p.ChiTietHoaDonXuats)
                .HasForeignKey(d => d.MaHoaDonXuat)
                .HasConstraintName("FK__ChiTietHo__MaHoa__628FA481");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietHoaDonXuats)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__ChiTietHo__MaSan__6383C8BA");
        });

        modelBuilder.Entity<DanhMuc>(entity =>
        {
            entity.HasKey(e => e.MaDanhMuc).HasName("PK__DanhMuc__B3750887735E6ABE");

            entity.ToTable("DanhMuc");

            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.TenDanhMuc).HasMaxLength(250);
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.MaDonHang).HasName("PK__DonHang__129584ADD6A9A2F7");

            entity.ToTable("DonHang");

            entity.Property(e => e.NgayDat).HasColumnType("datetime");

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaKhachHang)
                .HasConstraintName("FK_MaKhachHang");
        });

        modelBuilder.Entity<HoaDonNhap>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonNhap).HasName("PK__HoaDonNh__448838B5999E8C19");

            entity.ToTable("HoaDonNhap");

            entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            entity.Property(e => e.SoHoaDonNhap)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.HoaDonNhaps)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__HoaDonNha__MaNgu__4F7CD00D");

            entity.HasOne(d => d.MaNhaCungCapNavigation).WithMany(p => p.HoaDonNhaps)
                .HasForeignKey(d => d.MaNhaCungCap)
                .HasConstraintName("FK__HoaDonNha__MaNha__5070F446");
        });

        modelBuilder.Entity<HoaDonXuat>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonXuat).HasName("PK__HoaDonXu__FCBAF59B9D593A70");

            entity.ToTable("HoaDonXuat");

            entity.Property(e => e.NgayXuat).HasColumnType("datetime");
            entity.Property(e => e.SoHoaDonXuat)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.HoaDonXuats)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__HoaDonXua__MaNgu__5FB337D6");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__KhachHan__88D2F0E52006CA8E");

            entity.ToTable("KhachHang");

            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.TenKhachHang).HasMaxLength(250);
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MaMenu).HasName("PK__Menu__0EBABE42DE23B574");

            entity.ToTable("Menu");

            entity.Property(e => e.MoTa).HasMaxLength(250);
            entity.Property(e => e.TenMenu).HasMaxLength(250);
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.ManguoiDung).HasName("PK__NguoiDun__F6EACEEA64ACE8A4");

            entity.ToTable("NguoiDung");

            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.GioiTinh).HasMaxLength(20);
            entity.Property(e => e.HoTen).HasMaxLength(250);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNhaCungCap).HasName("PK__NhaCungC__53DA920583F9F0A5");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(250);
        });

        modelBuilder.Entity<NhaSanXuat>(entity =>
        {
            entity.HasKey(e => e.MaNhaSanXuat).HasName("PK__NhaSanXu__838C17A1B91046A5");

            entity.ToTable("NhaSanXuat");

            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.TenNhaSanXuat).HasMaxLength(250);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPham__FAC7442DFD82DAD8");

            entity.ToTable("SanPham");

            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.TenSanPham).HasMaxLength(250);

            entity.HasOne(d => d.MaDanhMucNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaDanhMuc)
                .HasConstraintName("FK__SanPham__MaDanhM__44FF419A");

            entity.HasOne(d => d.MaNhaSanXuatNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaNhaSanXuat)
                .HasConstraintName("FK__SanPham__MaNhaSa__45F365D3");
        });

        modelBuilder.Entity<Slide>(entity =>
        {
            entity.HasKey(e => e.MaSlide).HasName("PK__Slide__8522CE34BB82D055");

            entity.ToTable("Slide");

            entity.Property(e => e.TenSlide).HasMaxLength(250);
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTaiKhoan).HasName("PK__TaiKhoan__AD7C6529AF3764AD");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.MatKhau).HasMaxLength(100);
            entity.Property(e => e.TenDangNhap).HasMaxLength(100);

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__TaiKhoan__MaNguo__403A8C7D");
        });

        modelBuilder.Entity<ThongSoKyThuat>(entity =>
        {
            entity.HasKey(e => e.MaThongSo).HasName("PK__ThongSoK__60E16E64205656DD");

            entity.ToTable("ThongSoKyThuat");

            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.TenThongSo).HasMaxLength(250);

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ThongSoKyThuats)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__ThongSoKy__MaSan__4CA06362");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
