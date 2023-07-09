﻿// <auto-generated />
using System;
using CowsOnlineShop.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CowsOnlineShop.Api.Migrations
{
    [DbContext(typeof(CowShopDbContext))]
    partial class CowShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.19");

            modelBuilder.Entity("CowsOnlineShop.Api.Entities.BreedCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BreedCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Holstein"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hereford"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Aberdeen"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Belgian"
                        });
                });

            modelBuilder.Entity("CowsOnlineShop.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("CowsOnlineShop.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("CowsOnlineShop.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("BreedCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StockAvailable")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BreedCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 1,
                            Description = "International breed or group of breeds of dairy cattle",
                            ImageURL = "/Images/Holstein/Holstein1.png",
                            Name = "Holstein Friesian",
                            Price = 100m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 100
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 1,
                            Description = "International breed or group of breeds of dairy cattle",
                            ImageURL = "/Images/Holstein/Holstein2.png",
                            Name = "Holstein Friesian",
                            Price = 50m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 45
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 1,
                            Description = "International breed or group of breeds of dairy cattle",
                            ImageURL = "/Images/Holstein/Holstein3.png",
                            Name = "Holstein Friesian",
                            Price = 20m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 30
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 1,
                            Description = "International breed or group of breeds of dairy cattle",
                            ImageURL = "/Images/Holstein/Holstein4.png",
                            Name = "Holstein Friesian",
                            Price = 50m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 60
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 1,
                            Description = "International breed or group of breeds of dairy cattle",
                            ImageURL = "/Images/Holstein/Holstein4.png",
                            Name = "Holstein Friesian",
                            Price = 50m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 60
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 2,
                            Description = "Originally from Herefordshire in the West Midlands of England",
                            ImageURL = "/Images/Hereford/Hereford3.png",
                            Name = "Hereford cattle",
                            Price = 70m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 90
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 2,
                            Description = "Originally from Herefordshire in the West Midlands of England",
                            ImageURL = "/Images/Hereford/Hereford4.png",
                            Name = "Hereford cattle",
                            Price = 120m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 95
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 2,
                            Description = "Originally from Herefordshire in the West Midlands of England",
                            ImageURL = "/Images/Hereford/Hereford6.png",
                            Name = "Hereford cattle",
                            Price = 15m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 100
                        },
                        new
                        {
                            Id = 9,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 2,
                            Description = "Originally from Herefordshire in the West Midlands of England",
                            ImageURL = "/Images/Hereford/Hereford1.png",
                            Name = "Hereford cattle",
                            Price = 50m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 212
                        },
                        new
                        {
                            Id = 10,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 2,
                            Description = "Originally from Herefordshire in the West Midlands of England",
                            ImageURL = "/Images/Hereford/Hereford2.png",
                            Name = "Hereford cattle",
                            Price = 50m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 112
                        },
                        new
                        {
                            Id = 11,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 3,
                            Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                            ImageURL = "/Images/Aberdeen/Aberdeen2.png",
                            Name = "Aberdeen Angus",
                            Price = 40m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 200
                        },
                        new
                        {
                            Id = 12,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 3,
                            Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                            ImageURL = "/Images/Aberdeen/Aberdeen3.png",
                            Name = "Aberdeen Angus",
                            Price = 40m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 300
                        },
                        new
                        {
                            Id = 13,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 3,
                            Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                            ImageURL = "/Images/Aberdeen/Aberdeen4.png",
                            Name = "Aberdeen Angus",
                            Price = 600m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 20
                        },
                        new
                        {
                            Id = 14,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 3,
                            Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                            ImageURL = "/Images/Aberdeen/Aberdeen5.png",
                            Name = "Aberdeen Angus",
                            Price = 500m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 15
                        },
                        new
                        {
                            Id = 15,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 3,
                            Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                            ImageURL = "/Images/Aberdeen/Aberdeen1.png",
                            Name = "Aberdeen Angus",
                            Price = 100m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 120
                        },
                        new
                        {
                            Id = 16,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 4,
                            Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                            ImageURL = "/Images/Belgian/Belgian2.png",
                            Name = "Belgian Blue",
                            Price = 150m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 60
                        },
                        new
                        {
                            Id = 17,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 4,
                            Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                            ImageURL = "/Images/Belgian/Belgian3.png",
                            Name = "Belgian Blue",
                            Price = 200m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 70
                        },
                        new
                        {
                            Id = 18,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 4,
                            Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                            ImageURL = "/Images/Belgian/Belgian4.png",
                            Name = "Belgian Blue",
                            Price = 120m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 120
                        },
                        new
                        {
                            Id = 19,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 4,
                            Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                            ImageURL = "/Images/Belgian/Belgian5.png",
                            Name = "Belgian Blue",
                            Price = 200m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 100
                        },
                        new
                        {
                            Id = 20,
                            BirthDate = new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BreedCategoryId = 4,
                            Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                            ImageURL = "/Images/Belgian/Belgian1.png",
                            Name = "Belgian Blue",
                            Price = 100m,
                            Sex = 0,
                            Status = 1,
                            StockAvailable = 50
                        });
                });

            modelBuilder.Entity("CowsOnlineShop.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "User01"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "User02"
                        });
                });

            modelBuilder.Entity("CowsOnlineShop.Api.Entities.Product", b =>
                {
                    b.HasOne("CowsOnlineShop.Api.Entities.BreedCategory", "BreedCategory")
                        .WithMany()
                        .HasForeignKey("BreedCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BreedCategory");
                });
#pragma warning restore 612, 618
        }
    }
}