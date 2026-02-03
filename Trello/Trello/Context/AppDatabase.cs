using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Trello.Model;

namespace Trello.Context;

public partial class AppDatabase : DbContext
{
    public AppDatabase()
    {
    }

    public AppDatabase(DbContextOptions<AppDatabase> options)
        : base(options)
    {
    }

    public virtual DbSet<Board> Boards { get; set; }

    public virtual DbSet<BoardCard> BoardCards { get; set; }

    public virtual DbSet<BoardColumn> BoardColumns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Edina\\OneDrive - BMSZC Bláthy Ottó Titusz Informatikai Technikum\\Dokumentumok\\trello.mdf';Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Board>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Board__3214EC071D71821C");

            entity.ToTable("Board");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<BoardCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BoardCar__3214EC07EA2087E9");

            entity.ToTable("BoardCard");

            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.Column).WithMany(p => p.BoardCards)
                .HasForeignKey(d => d.ColumnId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__BoardCard__Colum__3B75D760");
        });

        modelBuilder.Entity<BoardColumn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BoardCol__3214EC0708D2DED0");

            entity.ToTable("BoardColumn");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Board).WithMany(p => p.BoardColumns)
                .HasForeignKey(d => d.BoardId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__BoardColu__Board__38996AB5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
