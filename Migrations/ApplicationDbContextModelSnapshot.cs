﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace QLNS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("QLNS.Models.ChucVu", b =>
                {
                    b.Property<string>("MaChucvu")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenChucvu")
                        .HasColumnType("TEXT");

                    b.HasKey("MaChucvu");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("QLNS.Models.Hopdong", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ngaybatdau")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ngayketthuc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNV");

                    b.ToTable("Hopdong");
                });

            modelBuilder.Entity("QLNS.Models.Nhansu", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("Chucvu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gioitinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Hoten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaChucvu")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaPhong")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNV");

                    b.HasIndex("MaChucvu");

                    b.HasIndex("MaPhong");

                    b.ToTable("Nhansu");
                });

            modelBuilder.Entity("QLNS.Models.Phongban", b =>
                {
                    b.Property<string>("MaPhong")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenPhong")
                        .HasColumnType("TEXT");

                    b.HasKey("MaPhong");

                    b.ToTable("Phongban");
                });

            modelBuilder.Entity("QLNS.Models.Nhansu", b =>
                {
                    b.HasOne("QLNS.Models.ChucVu", "TenChucvu")
                        .WithMany()
                        .HasForeignKey("MaChucvu");

                    b.HasOne("QLNS.Models.Phongban", "TenPhong")
                        .WithMany()
                        .HasForeignKey("MaPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TenChucvu");

                    b.Navigation("TenPhong");
                });
#pragma warning restore 612, 618
        }
    }
}
