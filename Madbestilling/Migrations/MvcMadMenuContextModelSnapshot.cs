﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMadMenu.Data;

namespace Madbestilling.Migrations
{
    [DbContext(typeof(MvcMadMenuContext))]
    partial class MvcMadMenuContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcMadMenu.Models.MadMenu", b =>
                {
                    b.Property<int>("Menuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dato")
                        .HasColumnType("datetime2");

                    b.Property<string>("Med_Hjem_Køkken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Menu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Uge")
                        .HasColumnType("int");

                    b.Property<string>("UgeNavn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Menuid");

                    b.ToTable("Madmenu");
                });
#pragma warning restore 612, 618
        }
    }
}
