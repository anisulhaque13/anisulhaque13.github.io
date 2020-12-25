﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Models;

namespace Portfolio.Migrations
{
    [DbContext(typeof(PFDbContext))]
    partial class PFDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Portfolio.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArticalTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TextContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticalTypeId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Portfolio.Models.ArticleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArticleTypes");
                });

            modelBuilder.Entity("Portfolio.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Portfolio.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Portfolio.Models.Exprience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Details")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Expriences");
                });

            modelBuilder.Entity("Portfolio.Models.Projects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfProject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Portfolio.Models.Article", b =>
                {
                    b.HasOne("Portfolio.Models.ArticleType", "ArticalType")
                        .WithMany()
                        .HasForeignKey("ArticalTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticalType");
                });
#pragma warning restore 612, 618
        }
    }
}
