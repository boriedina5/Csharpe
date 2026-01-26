using System;
using System.Collections.Generic;
using Dbgyakorlas.Models;
using Microsoft.EntityFrameworkCore;

namespace Dbgyakorlas.Context;

public partial class AppDatabase : DbContext
{
    public AppDatabase()
    {
    }

    public AppDatabase(DbContextOptions<AppDatabase> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Edina\\OneDrive - BMSZC Bláthy Ottó Titusz Informatikai Technikum\\Dokumentumok\\ordersdatabase.mdf';Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC078B3FE2B0");

            entity.ToTable("Customer");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC07E14B47B9");

            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Orders__Customer__3A81B327");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderDet__3214EC0792306400");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__OrderDeta__Order__3D5E1FD2");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__OrderDeta__Produ__3E52440B");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC072D47F39D");

            entity.ToTable("Product");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
