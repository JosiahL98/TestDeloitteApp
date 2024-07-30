﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestDeloitteApp.Data;

#nullable disable

namespace TestDeloitteApp.Data.Migrations
{
    [DbContext(typeof(TestDeloitteAppContext))]
    [Migration("20240717192642_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("TestDeloitteApp.Models.CaseDiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CaseId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Father")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("FatherViolence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mother")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("MotherViolence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Open")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Prim")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubFunction")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CaseDiaries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CaseId = "2323",
                            DueDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1219),
                            Father = "asassa",
                            FatherViolence = false,
                            Function = "aaaaa",
                            Mother = "asassa",
                            MotherViolence = true,
                            Open = "Yes",
                            Prim = "No",
                            StartDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1177),
                            SubFunction = "bbbb"
                        },
                        new
                        {
                            Id = 2,
                            CaseId = "2323",
                            DueDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1228),
                            Father = "asassa",
                            FatherViolence = false,
                            Function = "aaaaa",
                            Mother = "asassa",
                            MotherViolence = true,
                            Open = "Yes",
                            Prim = "No",
                            StartDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1226),
                            SubFunction = "bbbb"
                        },
                        new
                        {
                            Id = 3,
                            CaseId = "2323",
                            DueDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1236),
                            Father = "asassa",
                            FatherViolence = false,
                            Function = "aaaaa",
                            Mother = "asassa",
                            MotherViolence = true,
                            Open = "Yes",
                            Prim = "No",
                            StartDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1232),
                            SubFunction = "bbbb"
                        },
                        new
                        {
                            Id = 4,
                            CaseId = "2323",
                            DueDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1240),
                            Father = "asassa",
                            FatherViolence = false,
                            Function = "aaaaa",
                            Mother = "asassa",
                            MotherViolence = true,
                            Open = "Yes",
                            Prim = "No",
                            StartDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1238),
                            SubFunction = "bbbb"
                        },
                        new
                        {
                            Id = 5,
                            CaseId = "2323",
                            DueDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1244),
                            Father = "asassa",
                            FatherViolence = false,
                            Function = "aaaaa",
                            Mother = "asassa",
                            MotherViolence = true,
                            Open = "Yes",
                            Prim = "No",
                            StartDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1243),
                            SubFunction = "bbbb"
                        },
                        new
                        {
                            Id = 6,
                            CaseId = "111",
                            DueDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1249),
                            Father = "asassa",
                            FatherViolence = false,
                            Function = "aaaaa",
                            Mother = "asassa",
                            MotherViolence = true,
                            Open = "Yes",
                            Prim = "No",
                            StartDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1247),
                            SubFunction = "bbbb"
                        },
                        new
                        {
                            Id = 7,
                            CaseId = "111",
                            DueDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1253),
                            Father = "asassa",
                            FatherViolence = false,
                            Function = "aaaaa",
                            Mother = "asassa",
                            MotherViolence = true,
                            Open = "Yes",
                            Prim = "No",
                            StartDate = new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1252),
                            SubFunction = "bbbb"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}