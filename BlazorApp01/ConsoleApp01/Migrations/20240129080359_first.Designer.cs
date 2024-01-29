﻿// <auto-generated />
using System;
using ConsoleApp01.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp01.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20240129080359_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("ConsoleApp01.Data.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistrationNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8129eeb7-029a-4ef7-96fb-b1c45608f767"),
                            Email = "Margarita_Lindgren44@gmail.com",
                            FirstName = "Margarita",
                            LastName = "Lindgren",
                            Phone = "476-779-4370 x08371",
                            RegistrationNo = "EG/2045/06243"
                        },
                        new
                        {
                            Id = new Guid("931f1eb8-5892-4cd6-9b2f-4cce771c0c49"),
                            Email = "Mathilde9@gmail.com",
                            FirstName = "Mathilde",
                            LastName = "Ledner",
                            Phone = "1-344-239-3110 x53703",
                            RegistrationNo = "EG/2042/09702"
                        },
                        new
                        {
                            Id = new Guid("692c6e43-fc9b-4282-9cc4-014caf8ab68d"),
                            Email = "Mitchel_Borer@yahoo.com",
                            FirstName = "Mitchel",
                            LastName = "Borer",
                            Phone = "(895) 249-1947 x32181",
                            RegistrationNo = "EG/2025/06947"
                        },
                        new
                        {
                            Id = new Guid("36897ecf-e6ef-4e0f-86ad-a4ffc8e8d951"),
                            Email = "Braulio_Jones93@hotmail.com",
                            FirstName = "Braulio",
                            LastName = "Jones",
                            Phone = "810.425.6898 x54144",
                            RegistrationNo = "EG/2034/08075"
                        },
                        new
                        {
                            Id = new Guid("9cba46e9-9d1b-4633-b5e2-7279baff1473"),
                            Email = "Buford91@gmail.com",
                            FirstName = "Buford",
                            LastName = "Walsh",
                            Phone = "529-971-3567",
                            RegistrationNo = "EG/2023/08762"
                        },
                        new
                        {
                            Id = new Guid("77aa0f0d-6eef-4a52-aee4-a0277acb60a0"),
                            Email = "Dallin.Grant55@yahoo.com",
                            FirstName = "Dallin",
                            LastName = "Grant",
                            Phone = "(666) 407-2654 x84596",
                            RegistrationNo = "EG/2030/04799"
                        },
                        new
                        {
                            Id = new Guid("9f21b39a-e4f6-4004-80bf-827cc633ffee"),
                            Email = "Wallace_Hudson87@hotmail.com",
                            FirstName = "Wallace",
                            LastName = "Hudson",
                            Phone = "1-606-676-6585",
                            RegistrationNo = "EG/2033/03529"
                        },
                        new
                        {
                            Id = new Guid("42270363-162b-4ff2-a537-e04f6be49b88"),
                            Email = "Kassandra20@hotmail.com",
                            FirstName = "Kassandra",
                            LastName = "Grimes",
                            Phone = "848.323.2533 x369",
                            RegistrationNo = "EG/2038/09829"
                        },
                        new
                        {
                            Id = new Guid("2bb15c87-f5b6-4eab-9ff2-05b97c6e1d74"),
                            Email = "Raegan.Kris21@gmail.com",
                            FirstName = "Raegan",
                            LastName = "Kris",
                            Phone = "(975) 850-9453",
                            RegistrationNo = "EG/2023/08943"
                        },
                        new
                        {
                            Id = new Guid("8ed8bd5a-4618-4b58-99dc-535e4db02855"),
                            Email = "Westley_Reilly@yahoo.com",
                            FirstName = "Westley",
                            LastName = "Reilly",
                            Phone = "(319) 978-0686",
                            RegistrationNo = "EG/2022/04656"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
