using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QuizzApp.Models;

namespace QuizzApp.Context;

public partial class AppDatabase : DbContext
{
    public AppDatabase()
    {
    }

    public AppDatabase(DbContextOptions<AppDatabase> options)
        : base(options)
    {
    }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<UserResult> UserResults { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GitHub\\Csharpe\\Trello\\QuizzApp\\quiz.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3214EC073D26EB44");

            entity.ToTable("Question");
        });

        modelBuilder.Entity<UserResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserResu__3214EC07DDC9CCE1");

            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
