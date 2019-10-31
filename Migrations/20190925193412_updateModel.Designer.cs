﻿// <auto-generated />
using System;
using CsharpProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CsharpProject.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190925193412_updateModel")]
    partial class updateModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CsharpProject.Models.Pet", b =>
                {
                    b.Property<string>("PetId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<byte[]>("Image");

                    b.Property<int>("PetAge");

                    b.Property<string>("PetBreed")
                        .IsRequired();

                    b.Property<string>("PetName")
                        .IsRequired();

                    b.Property<int?>("UserId");

                    b.HasKey("PetId");

                    b.HasIndex("UserId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("CsharpProject.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CsharpProject.Models.Pet", b =>
                {
                    b.HasOne("CsharpProject.Models.User")
                        .WithMany("LikedPets")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
