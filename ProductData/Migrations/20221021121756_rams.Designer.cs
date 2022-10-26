﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductData;

namespace ProductData.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20221021121756_rams")]
    partial class rams
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProductEntity.Article", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArticleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ColourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticleId");

                    b.HasIndex("ColourId");

                    b.HasIndex("ProductId");

                    b.ToTable("article");
                });

            modelBuilder.Entity("ProductEntity.Colour", b =>
                {
                    b.Property<Guid>("ColourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColourId");

                    b.ToTable("colour");
                });

            modelBuilder.Entity("ProductEntity.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductYear")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("ProductEntity.Size", b =>
                {
                    b.Property<Guid>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("size");
                });

            modelBuilder.Entity("ProductEntity.Article", b =>
                {
                    b.HasOne("ProductEntity.Colour", "Colour")
                        .WithMany()
                        .HasForeignKey("ColourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductEntity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colour");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}