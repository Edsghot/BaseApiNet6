﻿// <auto-generated />
using System;
using BaseApiNet6.Configuration.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaseApiNet6.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20241223065506_teamAdded")]
    partial class teamAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BaseApiNet6.Modules.Team.Domain.TeamEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ExperienceYears")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GitHubUrl")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<string>("InstagramUrl")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("LinkedInUrl")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.HasKey("Id");

                    b.ToTable("Team", (string)null);
                });

            modelBuilder.Entity("BaseApiNet6.Modules.User.Domain.Entity.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Years")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
