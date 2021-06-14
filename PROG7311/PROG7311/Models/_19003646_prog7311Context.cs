using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PROG7311.Models
{
    public partial class _19003646_prog7311Context : DbContext
    {
        public _19003646_prog7311Context()
        {
        }

        public _19003646_prog7311Context(DbContextOptions<_19003646_prog7311Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.CartId).HasColumnName("cartID");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__Carts__itemID__797309D9");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.Property(e => e.Price)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("price");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("userPassword");

                entity.Property(e => e.UserRole)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("userRole");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
