﻿// <auto-generated />
using EksamenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EksamenApi.Migrations
{
    [DbContext(typeof(restaurantContext))]
    partial class restaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("EksamenApi.Models.admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("EksamenApi.Models.customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("EksamenApi.Models.drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DrinkImagesrc")
                        .HasColumnType("TEXT");

                    b.Property<string>("DrinkName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DrinkPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("DrinkId");

                    b.ToTable("Drink");
                });

            modelBuilder.Entity("EksamenApi.Models.food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PizzaDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("PizzaImageSrc")
                        .HasColumnType("TEXT");

                    b.Property<string>("PizzaLabel")
                        .HasColumnType("TEXT");

                    b.Property<string>("PizzaName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PizzaPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("FoodId");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("EksamenApi.Models.menu", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DrinkId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FoodId");

                    b.ToTable("Menu");
                });
#pragma warning restore 612, 618
        }
    }
}
