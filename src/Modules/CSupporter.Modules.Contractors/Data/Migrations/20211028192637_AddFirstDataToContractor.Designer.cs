﻿// <auto-generated />
using System;
using CSupporter.Modules.Contractors.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSupporter.Modules.Contractors.Migrations
{
    [DbContext(typeof(CSupporterDbContext))]
    [Migration("20211028192637_AddFirstDataToContractor")]
    partial class AddFirstDataToContractor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSupporter.Modules.Contractors.Entities.Contractor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Contractors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b1bb5d92-f31e-4f32-a55d-6316ed65e783"),
                            Address = "Warszawa, ul. Przedszkolna 15",
                            CompanyDetails = "--",
                            CompanyName = "GM Prime RN",
                            FirstName = "Richard",
                            InsertDate = new DateTime(2021, 10, 28, 21, 26, 36, 786, DateTimeKind.Local).AddTicks(5877),
                            LastName = "Nowak",
                            NIP = "912-111-09-10",
                            UpdateDate = new DateTime(2021, 10, 28, 21, 26, 36, 786, DateTimeKind.Local).AddTicks(6003)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
