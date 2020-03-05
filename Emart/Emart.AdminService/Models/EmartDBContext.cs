﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Emart.AdminService.Models
{
    public partial class EmartDBContext : DbContext
    {
        public EmartDBContext()
        {
        }

        public EmartDBContext(DbContextOptions<EmartDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-FG8RRLB\\SQLEXPRESS;Initial Catalog=EmartDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__Buyer__7ED91ACEB2FCB0D3")
                    .IsUnique();

                entity.HasIndex(e => e.MobileNo)
                    .HasName("UQ__Buyer__D6D73A869DACDBD6")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("UQ__Buyer__C9F284568FCC550E")
                    .IsUnique();

                entity.Property(e => e.BuyerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.CategoryName)
                    .HasName("UQ__Category__8517B2E066C62607")
                    .IsUnique();

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BriefDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Percentage)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Items__727E838B7AB7373F");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StockNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubcategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Items__CategoryI__503BEA1C");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK__Items__SellerId__4F47C5E3");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK__Items__Subcatego__51300E55");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__Seller__7ED91ACE7571474D")
                    .IsUnique();

                entity.HasIndex(e => e.Gstin)
                    .HasName("UQ__Seller__0604E65F3D7977DA")
                    .IsUnique();

                entity.HasIndex(e => e.MobileNo)
                    .HasName("UQ__Seller__D6D73A86C59925D4")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("UQ__Seller__C9F28456CAA74681")
                    .IsUnique();

                entity.Property(e => e.SellerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BriefDetails)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .IsRequired()
                    .HasColumnName("GSTIN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddress)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasIndex(e => e.SubcategoryName)
                    .HasName("UQ__SubCateg__9BAD5E87A83F0F83")
                    .IsUnique();

                entity.Property(e => e.SubcategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BriefDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Gst)
                    .IsRequired()
                    .HasColumnName("GST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubcategoryName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__SubCatego__Categ__37703C52");
            });

            modelBuilder.Entity<TransactionHistory>(entity =>
            {
                entity.HasIndex(e => e.TransactionId)
                    .HasName("UQ__Transact__55433A6AEFE24904")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfItems)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.TransactionHistory)
                    .HasForeignKey(d => d.BuyerId)
                    .HasConstraintName("FK__Transacti__Buyer__55009F39");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TransactionHistory)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__Transacti__ItemI__56E8E7AB");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.TransactionHistory)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK__Transacti__Selle__55F4C372");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}