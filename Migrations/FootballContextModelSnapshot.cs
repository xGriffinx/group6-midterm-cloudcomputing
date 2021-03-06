﻿// <auto-generated />
using System;
using DotNetCoreSqlDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreSqlDb.Migrations
{
    [DbContext(typeof(FootballContext))]
    partial class FootballContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetCoreSqlDb.Playersstatistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("Fantasypoints")
                        .HasColumnType("int");

                    b.Property<int?>("Gamesplayed")
                        .HasColumnType("int");

                    b.Property<int?>("Passescompleted")
                        .HasColumnType("int");

                    b.Property<string>("Player")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Posrank")
                        .HasColumnType("int");

                    b.Property<double?>("Pprscoring")
                        .HasColumnType("float");

                    b.Property<int?>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("Team")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week9")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Playersstatistics");
                });

            modelBuilder.Entity("DotNetCoreSqlDb.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("userType");
                });
#pragma warning restore 612, 618
        }
    }
}
