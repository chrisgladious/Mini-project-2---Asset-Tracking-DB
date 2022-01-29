﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mini_project_2___Asset_Tracking_DB;

namespace Mini_project_2__Asset_Tracking_DB.Migrations
{
    [DbContext(typeof(AssetContext))]
    partial class AssetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mini_project_2___Asset_Tracking_DB.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExchangeRate")
                        .HasColumnType("float");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<int>("SortingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Assets");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Asset");
                });

            modelBuilder.Entity("Mini_project_2___Asset_Tracking_DB.ExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ExchangeRates");
                });

            modelBuilder.Entity("Mini_project_2___Asset_Tracking_DB.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Mini_project_2___Asset_Tracking_DB.Computer", b =>
                {
                    b.HasBaseType("Mini_project_2___Asset_Tracking_DB.Asset");

                    b.HasDiscriminator().HasValue("Computer");
                });

            modelBuilder.Entity("Mini_project_2___Asset_Tracking_DB.Phone", b =>
                {
                    b.HasBaseType("Mini_project_2___Asset_Tracking_DB.Asset");

                    b.HasDiscriminator().HasValue("Phone");
                });

            modelBuilder.Entity("Mini_project_2___Asset_Tracking_DB.Asset", b =>
                {
                    b.HasOne("Mini_project_2___Asset_Tracking_DB.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");
                });
#pragma warning restore 612, 618
        }
    }
}
