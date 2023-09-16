﻿// <auto-generated />
using CardstopRazor_Temp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardstopRazor_Temp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230916023418_AddCategoryToDb")]
    partial class AddCategoryToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.7.23375.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardstopRazor_Temp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Normal Monster"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Effect Monster"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Fusion Monster"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Synchro Monster"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Ritual Monster"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "XYZ Monster"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Link Monster"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Normal Trap Card"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Counter Trap Card"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "Normal Spell Card"
                        },
                        new
                        {
                            Id = 11,
                            DisplayOrder = 11,
                            Name = "Continuous Spell Card"
                        },
                        new
                        {
                            Id = 12,
                            DisplayOrder = 12,
                            Name = "Equip Spell Card"
                        },
                        new
                        {
                            Id = 13,
                            DisplayOrder = 13,
                            Name = "Quick-play Spell Card"
                        },
                        new
                        {
                            Id = 14,
                            DisplayOrder = 14,
                            Name = "Field Spell Card"
                        },
                        new
                        {
                            Id = 15,
                            DisplayOrder = 15,
                            Name = "Ritual Spell Card"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
