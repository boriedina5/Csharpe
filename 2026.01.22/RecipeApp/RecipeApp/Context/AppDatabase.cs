using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Models;

namespace RecipeApp.Context;

public partial class AppDatabase : DbContext
{
    public AppDatabase()
    {
    }

    public AppDatabase(DbContextOptions<AppDatabase> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }

    public virtual DbSet<UserPantry> UserPantries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GitHub\\Csharpe\\RecipeApp\\RecipeApp\\receptek.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingredie__3214EC073F1C60D6");

            entity.ToTable("Ingredient");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recipe__3214EC072FEC9AA2");

            entity.ToTable("Recipe");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RecipeIn__3214EC0755A1C368");

            entity.ToTable("RecipeIngredient");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__RecipeIng__Ingre__3C69FB99");

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__RecipeIng__Recip__3B75D760");
        });

        modelBuilder.Entity<UserPantry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserPant__3214EC072D4DEE90");

            entity.ToTable("UserPantry");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.UserPantries)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__UserPantr__Ingre__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
