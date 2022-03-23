﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project2.Models;

namespace project2.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    partial class AppointmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("project2.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentID");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
<<<<<<< Updated upstream
                            AppointmentID = -1,
                            Email = "Test@test.net",
                            GroupName = "Tester",
                            GroupSize = 3,
                            Phone = "517-879-6543",
                            Time = new DateTime(2022, 3, 30, 1, 14, 50, 0, DateTimeKind.Unspecified)
=======
                            TimeId = 1,
                            AppointmentTime = new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 2,
                            AppointmentTime = new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 3,
                            AppointmentTime = new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 4,
                            AppointmentTime = new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 5,
                            AppointmentTime = new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 6,
                            AppointmentTime = new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 7,
                            AppointmentTime = new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 8,
                            AppointmentTime = new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 9,
                            AppointmentTime = new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 10,
                            AppointmentTime = new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 11,
                            AppointmentTime = new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 12,
                            AppointmentTime = new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 13,
                            AppointmentTime = new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 14,
                            AppointmentTime = new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 15,
                            AppointmentTime = new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 16,
                            AppointmentTime = new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 17,
                            AppointmentTime = new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 18,
                            AppointmentTime = new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 19,
                            AppointmentTime = new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 20,
                            AppointmentTime = new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 21,
                            AppointmentTime = new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 22,
                            AppointmentTime = new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 23,
                            AppointmentTime = new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 24,
                            AppointmentTime = new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 25,
                            AppointmentTime = new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 26,
                            AppointmentTime = new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 27,
                            AppointmentTime = new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 28,
                            AppointmentTime = new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 29,
                            AppointmentTime = new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 30,
                            AppointmentTime = new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 31,
                            AppointmentTime = new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 32,
                            AppointmentTime = new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 33,
                            AppointmentTime = new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 34,
                            AppointmentTime = new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 35,
                            AppointmentTime = new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 36,
                            AppointmentTime = new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 37,
                            AppointmentTime = new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 38,
                            AppointmentTime = new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 39,
                            AppointmentTime = new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 40,
                            AppointmentTime = new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 41,
                            AppointmentTime = new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 42,
                            AppointmentTime = new DateTime(2022, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 43,
                            AppointmentTime = new DateTime(2022, 4, 4, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 44,
                            AppointmentTime = new DateTime(2022, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 45,
                            AppointmentTime = new DateTime(2022, 4, 4, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 46,
                            AppointmentTime = new DateTime(2022, 4, 4, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 47,
                            AppointmentTime = new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 48,
                            AppointmentTime = new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 49,
                            AppointmentTime = new DateTime(2022, 4, 4, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 50,
                            AppointmentTime = new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 51,
                            AppointmentTime = new DateTime(2022, 4, 4, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 52,
                            AppointmentTime = new DateTime(2022, 4, 4, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 53,
                            AppointmentTime = new DateTime(2022, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 54,
                            AppointmentTime = new DateTime(2022, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 55,
                            AppointmentTime = new DateTime(2022, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 56,
                            AppointmentTime = new DateTime(2022, 4, 5, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 57,
                            AppointmentTime = new DateTime(2022, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 58,
                            AppointmentTime = new DateTime(2022, 4, 5, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 59,
                            AppointmentTime = new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 60,
                            AppointmentTime = new DateTime(2022, 4, 5, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 61,
                            AppointmentTime = new DateTime(2022, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 62,
                            AppointmentTime = new DateTime(2022, 4, 5, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 63,
                            AppointmentTime = new DateTime(2022, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 64,
                            AppointmentTime = new DateTime(2022, 4, 5, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 65,
                            AppointmentTime = new DateTime(2022, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 66,
                            AppointmentTime = new DateTime(2022, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 67,
                            AppointmentTime = new DateTime(2022, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 68,
                            AppointmentTime = new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 69,
                            AppointmentTime = new DateTime(2022, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 70,
                            AppointmentTime = new DateTime(2022, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 71,
                            AppointmentTime = new DateTime(2022, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 72,
                            AppointmentTime = new DateTime(2022, 4, 6, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 73,
                            AppointmentTime = new DateTime(2022, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 74,
                            AppointmentTime = new DateTime(2022, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 75,
                            AppointmentTime = new DateTime(2022, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 76,
                            AppointmentTime = new DateTime(2022, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 77,
                            AppointmentTime = new DateTime(2022, 4, 6, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 78,
                            AppointmentTime = new DateTime(2022, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 79,
                            AppointmentTime = new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 80,
                            AppointmentTime = new DateTime(2022, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 81,
                            AppointmentTime = new DateTime(2022, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 82,
                            AppointmentTime = new DateTime(2022, 4, 7, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 83,
                            AppointmentTime = new DateTime(2022, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 84,
                            AppointmentTime = new DateTime(2022, 4, 7, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 85,
                            AppointmentTime = new DateTime(2022, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 86,
                            AppointmentTime = new DateTime(2022, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 87,
                            AppointmentTime = new DateTime(2022, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 88,
                            AppointmentTime = new DateTime(2022, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 89,
                            AppointmentTime = new DateTime(2022, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 90,
                            AppointmentTime = new DateTime(2022, 4, 7, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
                        },
                        new
                        {
                            TimeId = 91,
                            AppointmentTime = new DateTime(2022, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            taken = false
>>>>>>> Stashed changes
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
