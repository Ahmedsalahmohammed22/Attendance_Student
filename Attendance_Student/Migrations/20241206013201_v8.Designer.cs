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
    [Migration("20241206013201_v8")]
    partial class v8
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

            modelBuilder.Entity("Attendance_Student.Models.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeTableId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("dateAttendance")
                        .HasColumnType("date");

                    b.Property<string>("teacher_id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TimeTableId");

                    b.HasIndex("teacher_id");

                    b.ToTable("Attendances");
                });

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
                });

            modelBuilder.Entity("Attendance_Student.Models.DaySchedule", b =>
                {
                    b.Property<int>("DayScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayScheduleId"));

                    b.Property<string>("Dayname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeTable_id")
                        .HasColumnType("int");

                    b.HasKey("DayScheduleId");

                    b.HasIndex("TimeTable_id");

                    b.ToTable("DaySchedules");
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
                });

            modelBuilder.Entity("Attendance_Student.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Parent_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateOnly>("sendDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("Parent_Id");

                    b.HasIndex("admin_id");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("Attendance_Student.Models.StudentAttendance", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AttendanceId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId", "AttendanceId");

                    b.HasIndex("AttendanceId");

                    b.ToTable("StudentAttendances");
                });

            modelBuilder.Entity("Attendance_Student.Models.Subject", b =>
                {
                    b.Property<int>("subject_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subject_Id"));

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<int>("subject_Duration")
                        .HasColumnType("int");

                    b.Property<string>("subject_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("subject_Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Attendance_Student.Models.SubjectDaySchedule", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("DayScheduleId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("SubjectId", "DayScheduleId");

                    b.HasIndex("DayScheduleId");

                    b.ToTable("SubjectDaySchedule");
                });

            modelBuilder.Entity("Attendance_Student.Models.TimeTable", b =>
                {
                    b.Property<int>("TimeTableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimeTableId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("class_id")
                        .HasColumnType("int");

                    b.HasKey("TimeTableId");

                    b.HasIndex("class_id")
                        .IsUnique();

                    b.ToTable("TimeTables");
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

            modelBuilder.Entity("Attendance_Student.Models.Admin", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Attendance_Student.Models.Parent", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("fullname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToTable("AspNetUsers", t =>
                        {
                            t.Property("address")
                                .HasColumnName("Parent_address");

                            t.Property("age")
                                .HasColumnName("Parent_age");
                        });

                    b.HasDiscriminator().HasValue("Parent");
                });

            modelBuilder.Entity("Attendance_Student.Models.Student", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("NotificationId")
                        .HasColumnType("int");

                    b.Property<string>("ParentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Student_fullname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasIndex("ClassId");

                    b.HasIndex("NotificationId");

                    b.HasIndex("ParentId");

                    b.ToTable("AspNetUsers", t =>
                        {
                            t.Property("age")
                                .HasColumnName("Student_age");
                        });

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Attendance_Student.Models.Teacher", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("Teacher_fullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasIndex("DeptId");

                    b.HasIndex("SubjectId");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("Attendance_Student.Models.Attendance", b =>
                {
                    b.HasOne("Attendance_Student.Models.TimeTable", "timeTable")
                        .WithMany()
                        .HasForeignKey("TimeTableId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Attendance_Student.Models.Teacher", "teacher")
                        .WithMany("AttendanceRecords")
                        .HasForeignKey("teacher_id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("teacher");

                    b.Navigation("timeTable");
                });

            modelBuilder.Entity("Attendance_Student.Models.DaySchedule", b =>
                {
                    b.HasOne("Attendance_Student.Models.TimeTable", "timeTable")
                        .WithMany("DaySchedules")
                        .HasForeignKey("TimeTable_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("timeTable");
                });

            modelBuilder.Entity("Attendance_Student.Models.Notification", b =>
                {
                    b.HasOne("Attendance_Student.Models.Parent", "Parent")
                        .WithMany()
                        .HasForeignKey("Parent_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Attendance_Student.Models.Admin", "admin")
                        .WithMany("Notifications")
                        .HasForeignKey("admin_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("admin");
                });

            modelBuilder.Entity("Attendance_Student.Models.StudentAttendance", b =>
                {
                    b.HasOne("Attendance_Student.Models.Attendance", "attendance")
                        .WithMany("StudentsAttendance")
                        .HasForeignKey("AttendanceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Attendance_Student.Models.Student", "student")
                        .WithMany("viewAttendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("attendance");

                    b.Navigation("student");
                });

            modelBuilder.Entity("Attendance_Student.Models.Subject", b =>
                {
                    b.HasOne("Attendance_Student.Models.Department", "department")
                        .WithMany("Subjects")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("Attendance_Student.Models.SubjectDaySchedule", b =>
                {
                    b.HasOne("Attendance_Student.Models.DaySchedule", "daySchedule")
                        .WithMany("subjectsScheduled")
                        .HasForeignKey("DayScheduleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Attendance_Student.Models.Subject", "subject")
                        .WithMany("daysScheduled")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("daySchedule");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("Attendance_Student.Models.TimeTable", b =>
                {
                    b.HasOne("Attendance_Student.Models.Class", "_class")
                        .WithOne("timeTable")
                        .HasForeignKey("Attendance_Student.Models.TimeTable", "class_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("_class");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Student.Models.Student", b =>
                {
                    b.HasOne("Attendance_Student.Models.Class", "_class")
                        .WithMany("students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Attendance_Student.Models.Notification", null)
                        .WithMany("Students")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Attendance_Student.Models.Parent", "parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("_class");

                    b.Navigation("parent");
                });

            modelBuilder.Entity("Attendance_Student.Models.Teacher", b =>
                {
                    b.HasOne("Attendance_Student.Models.Department", "department")
                        .WithMany("Teachers")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Attendance_Student.Models.Subject", "Subject")
                        .WithMany("teachers")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("department");
                });

            modelBuilder.Entity("Attendance_Student.Models.Attendance", b =>
                {
                    b.Navigation("StudentsAttendance");
                });

            modelBuilder.Entity("Attendance_Student.Models.Class", b =>
                {
                    b.Navigation("students");

                    b.Navigation("timeTable")
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Student.Models.DaySchedule", b =>
                {
                    b.Navigation("subjectsScheduled");
                });

            modelBuilder.Entity("Attendance_Student.Models.Department", b =>
                {
                    b.Navigation("Subjects");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Attendance_Student.Models.Notification", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Attendance_Student.Models.Subject", b =>
                {
                    b.Navigation("daysScheduled");

                    b.Navigation("teachers");
                });

            modelBuilder.Entity("Attendance_Student.Models.TimeTable", b =>
                {
                    b.Navigation("DaySchedules");
                });

            modelBuilder.Entity("Attendance_Student.Models.Admin", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("Attendance_Student.Models.Parent", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Attendance_Student.Models.Student", b =>
                {
                    b.Navigation("viewAttendances");
                });

            modelBuilder.Entity("Attendance_Student.Models.Teacher", b =>
                {
                    b.Navigation("AttendanceRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
