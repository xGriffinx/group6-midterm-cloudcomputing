﻿// <auto-generated />
using DotNetCoreSqlDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreSqlDb.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    [Migration("20201018045140_AddProperty2")]
    partial class AddProperty2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetCoreSqlDb.Models.Playersstatistics", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Fantasypoints")
                        .HasColumnType("int");

                    b.Property<int>("Gamesplayed")
                        .HasColumnType("int");

                    b.Property<int>("Passescompleted")
                        .HasColumnType("int");

                    b.Property<string>("Player")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Posrank")
                        .HasColumnType("int");

                    b.Property<float>("Pprscoring")
                        .HasColumnType("real");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("Team")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("week9")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Playersstatistics");
                });

            modelBuilder.Entity("DotNetCoreSqlDb.Models.userType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
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

                    b.HasKey("ID");

                    b.ToTable("userType");
                });
#pragma warning restore 612, 618
        }
    }
}
