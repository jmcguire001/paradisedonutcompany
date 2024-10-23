using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace paradisedonutcompany.Models;

public partial class IcecreamdonutsContext : DbContext
{
    public IcecreamdonutsContext()
    {
    }

    public IcecreamdonutsContext(DbContextOptions<IcecreamdonutsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Flavor> Flavors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("Server=milestone-2-mydbinstance-ypkxpqgfrrgs.c5owe0yoofdg.us-east-2.rds.amazonaws.com;Database=icecreamdonuts;User=admin;Password=password", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.39-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Flavor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("flavor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Flavorname)
                .HasMaxLength(45)
                .HasColumnName("flavorname");
            entity.Property(e => e.Image)
                .HasMaxLength(45)
                .HasColumnName("image");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
