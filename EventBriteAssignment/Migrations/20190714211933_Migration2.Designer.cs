﻿// <auto-generated />
using System;
using EventBriteAssignment3A.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventBriteAssignment3A.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20190714211933_Migration2")]
    partial class Migration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.catalog_category_hilo", "'catalog_category_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.catalog_hilo", "'catalog_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.catalog_location_hilo", "'catalog_location_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventBriteCatalog.Domain.CatalogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_category_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Category")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogCategories");
                });

            modelBuilder.Entity("EventBriteCatalog.Domain.CatalogItem", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("CatalogCategoryId");

                    b.Property<int>("CatalogLocationId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("EventEndTime");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("EventStartTime");

                    b.Property<string>("PictureUrl");

                    b.Property<decimal>("Price");

                    b.HasKey("EventId");

                    b.HasIndex("CatalogCategoryId");

                    b.HasIndex("CatalogLocationId");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("EventBriteCatalog.Domain.CatalogLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_location_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Location")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogLocation");
                });

            modelBuilder.Entity("EventBriteCatalog.Domain.CatalogItem", b =>
                {
                    b.HasOne("EventBriteCatalog.Domain.CatalogCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CatalogCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventBriteCatalog.Domain.CatalogLocation", "Location")
                        .WithMany()
                        .HasForeignKey("CatalogLocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
