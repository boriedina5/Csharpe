using System;
using System.Collections.Generic;
using FajlBeolvDbvel.Models;
using Microsoft.EntityFrameworkCore;

namespace FajlBeolvDbvel.Context;

public partial class AppDatatbase : DbContext
{
    public AppDatatbase()
    {
    }

    public AppDatatbase(DbContextOptions<AppDatatbase> options)
        : base(options)
    {
    }

    public virtual DbSet<Character> Characters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GitHub\\Csharpe\\FajlBeolvDbvel\\fajlbeolvdb.mdf;Integrated Security=True;Connect Timeout=30;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Characte__3214EC07B6669FA8");

            entity.ToTable("Character");

            entity.Property(e => e.Class).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
