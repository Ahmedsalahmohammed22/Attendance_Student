﻿// <auto-generated />
using System;
using Attendance_Student.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Attendance_Student.Migrations
{
    [DbContext(typeof(AttendanceStudentContext))]
    [Migration("20241126212608_v5")]
    partial class v5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Attendance_Student.Models.Class", b =>
                {
                    b.Property<int>("Class_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Class_Id"));

                    b.Property<string>("Class_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Class_Size")
                        .HasColumnType("int");

                    b.HasKey("Class_Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Class_Id = 1,
                            Class_Name = "Class A",
                            Class_Size = 30
                        },
                        new
                        {
                            Class_Id = 2,
                            Class_Name = "Class B",
                            Class_Size = 25
                        },
                        new
                        {
                            Class_Id = 3,
                            Class_Name = "Class C",
                            Class_Size = 20
                        });
                });

            modelBuilder.Entity("Attendance_Student.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer Science"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mechanical Engineering"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electrical Engineering"
                        });
                });

            modelBuilder.Entity("Attendance_Student.Models.Subject", b =>
                {
                    b.Property<int>("subject_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subject_Id"));

                    b.Property<int>("subject_Duration")
                        .HasColumnType("int");

                    b.Property<string>("subject_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("timeTable_Id")
                        .HasColumnType("int");

                    b.HasKey("subject_Id");

                    b.HasIndex("timeTable_Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            subject_Id = 1,
                            subject_Duration = 60,
                            subject_Name = "Mathematics"
                        },
                        new
                        {
                            subject_Id = 2,
                            subject_Duration = 60,
                            subject_Name = "Physics"
                        },
                        new
                        {
                            subject_Id = 3,
                            subject_Duration = 60,
                            subject_Name = "Chemistry"
                        });
                });

            modelBuilder.Entity("Attendance_Student.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Street, City",
                            DeptId = 1,
                            Name = "John Smith",
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Avenue, City",
                            DeptId = 2,
                            Name = "Alice Johnson",
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Boulevard, City",
                            DeptId = 3,
                            Name = "Robert Brown",
                            SubjectId = 3
                        });
                });

            modelBuilder.Entity("Attendance_Student.Models.TimeTable", b =>
                {
                    b.Property<int>("timeTable_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("timeTable_Id");

                    b.ToTable("TimeTables");

                    b.HasData(
                        new
                        {
                            timeTable_Id = 1,
                            CreatedDate = new DateTime(2024, 11, 26, 21, 26, 7, 479, DateTimeKind.Utc).AddTicks(6233),
                            LastUpdatedDate = new DateTime(2024, 11, 26, 21, 26, 7, 479, DateTimeKind.Utc).AddTicks(6237)
                        },
                        new
                        {
                            timeTable_Id = 2,
                            CreatedDate = new DateTime(2024, 11, 26, 21, 26, 7, 479, DateTimeKind.Utc).AddTicks(6239),
                            LastUpdatedDate = new DateTime(2024, 11, 26, 21, 26, 7, 479, DateTimeKind.Utc).AddTicks(6239)
                        },
                        new
                        {
                            timeTable_Id = 3,
                            CreatedDate = new DateTime(2024, 11, 26, 21, 26, 7, 479, DateTimeKind.Utc).AddTicks(6241),
                            LastUpdatedDate = new DateTime(2024, 11, 26, 21, 26, 7, 479, DateTimeKind.Utc).AddTicks(6241)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Attendance_Student.Models.Student", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("Class_Id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Class_Id");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "46f2ce7e-12ab-42c1-b46c-a451796f9b91",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2db44203-3ea7-4791-80a8-47d570b7428c",
                            TwoFactorEnabled = false,
                            UserName = "student1",
                            Class_Id = 1,
                            Status = "Active"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "91823605-f71a-4aff-99b2-f47289e45c97",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "10abaf5e-70dd-4ddb-b13c-cdeacd807c5f",
                            TwoFactorEnabled = false,
                            UserName = "student2",
                            Class_Id = 2,
                            Status = "Active"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bed8e469-59f0-40a5-b805-bf19f81f8d08",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0cfb4ae7-0445-4fb4-9222-0703d65a87a9",
                            TwoFactorEnabled = false,
                            UserName = "student3",
                            Class_Id = 3,
                            Status = "Inactive"
                        });
                });

            modelBuilder.Entity("Attendance_Student.Models.Subject", b =>
                {
                    b.HasOne("Attendance_Student.Models.TimeTable", null)
                        .WithMany("subjects")
                        .HasForeignKey("timeTable_Id");
                });

            modelBuilder.Entity("Attendance_Student.Models.Teacher", b =>
                {
                    b.HasOne("Attendance_Student.Models.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance_Student.Models.Subject", "Subject")
                        .WithMany("teachers")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Attendance_Student.Models.TimeTable", b =>
                {
                    b.HasOne("Attendance_Student.Models.Class", "_class")
                        .WithOne("timeTable")
                        .HasForeignKey("Attendance_Student.Models.TimeTable", "timeTable_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_class");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Student.Models.Student", b =>
                {
                    b.HasOne("Attendance_Student.Models.Class", "_class")
                        .WithMany("students")
                        .HasForeignKey("Class_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_class");
                });

            modelBuilder.Entity("Attendance_Student.Models.Class", b =>
                {
                    b.Navigation("students");

                    b.Navigation("timeTable")
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Student.Models.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Attendance_Student.Models.Subject", b =>
                {
                    b.Navigation("teachers");
                });

            modelBuilder.Entity("Attendance_Student.Models.TimeTable", b =>
                {
                    b.Navigation("subjects");
                });
#pragma warning restore 612, 618
        }
    }
}