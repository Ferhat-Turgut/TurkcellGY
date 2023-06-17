﻿// <auto-generated />
using System;
using CareerApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CareerApp.Infrastructure.Migrations
{
    [DbContext(typeof(CareerAppDbContext))]
    [Migration("20230610133650_mig_identity_add1")]
    partial class mig_identity_add1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CareerApp.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "adana"
                        },
                        new
                        {
                            Id = 2,
                            Name = "adıyaman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "afyonkarahisar"
                        },
                        new
                        {
                            Id = 4,
                            Name = "ağrı"
                        },
                        new
                        {
                            Id = 5,
                            Name = "amasya"
                        },
                        new
                        {
                            Id = 6,
                            Name = "ankara"
                        },
                        new
                        {
                            Id = 7,
                            Name = "antalya"
                        },
                        new
                        {
                            Id = 8,
                            Name = "artvin"
                        },
                        new
                        {
                            Id = 9,
                            Name = "aydın"
                        },
                        new
                        {
                            Id = 10,
                            Name = "balıkesir"
                        },
                        new
                        {
                            Id = 11,
                            Name = "bilecik"
                        },
                        new
                        {
                            Id = 12,
                            Name = "bingöl"
                        },
                        new
                        {
                            Id = 13,
                            Name = "bitlis"
                        },
                        new
                        {
                            Id = 14,
                            Name = "bolu"
                        },
                        new
                        {
                            Id = 15,
                            Name = "burdur"
                        },
                        new
                        {
                            Id = 16,
                            Name = "bursa"
                        },
                        new
                        {
                            Id = 17,
                            Name = "çanakkale"
                        },
                        new
                        {
                            Id = 18,
                            Name = "çankırı"
                        },
                        new
                        {
                            Id = 19,
                            Name = "çorum"
                        },
                        new
                        {
                            Id = 20,
                            Name = "denizli"
                        },
                        new
                        {
                            Id = 21,
                            Name = "diyarbakır"
                        },
                        new
                        {
                            Id = 22,
                            Name = "edirne"
                        },
                        new
                        {
                            Id = 23,
                            Name = "elazığ"
                        },
                        new
                        {
                            Id = 24,
                            Name = "erzincan"
                        },
                        new
                        {
                            Id = 25,
                            Name = "erzurum"
                        },
                        new
                        {
                            Id = 26,
                            Name = "eskişehir"
                        },
                        new
                        {
                            Id = 27,
                            Name = "gaziantep"
                        },
                        new
                        {
                            Id = 28,
                            Name = "giresun"
                        },
                        new
                        {
                            Id = 29,
                            Name = "gümüşhane"
                        },
                        new
                        {
                            Id = 30,
                            Name = "hakkari"
                        },
                        new
                        {
                            Id = 31,
                            Name = "hatay"
                        },
                        new
                        {
                            Id = 32,
                            Name = "ısparta"
                        },
                        new
                        {
                            Id = 33,
                            Name = "mersin"
                        },
                        new
                        {
                            Id = 34,
                            Name = "istanbul"
                        },
                        new
                        {
                            Id = 35,
                            Name = "izmir"
                        },
                        new
                        {
                            Id = 36,
                            Name = "kars"
                        },
                        new
                        {
                            Id = 37,
                            Name = "kastamonu"
                        },
                        new
                        {
                            Id = 38,
                            Name = "kayseri"
                        },
                        new
                        {
                            Id = 39,
                            Name = "kırklareli"
                        },
                        new
                        {
                            Id = 40,
                            Name = "kırşehir"
                        },
                        new
                        {
                            Id = 41,
                            Name = "kocaeli"
                        },
                        new
                        {
                            Id = 42,
                            Name = "konya"
                        },
                        new
                        {
                            Id = 43,
                            Name = "kütahya"
                        },
                        new
                        {
                            Id = 44,
                            Name = "malatya"
                        },
                        new
                        {
                            Id = 45,
                            Name = "manisa"
                        },
                        new
                        {
                            Id = 46,
                            Name = "kahramanmaraş"
                        },
                        new
                        {
                            Id = 47,
                            Name = "mardin"
                        },
                        new
                        {
                            Id = 48,
                            Name = "muğla"
                        },
                        new
                        {
                            Id = 49,
                            Name = "muş"
                        },
                        new
                        {
                            Id = 50,
                            Name = "nevşehir"
                        },
                        new
                        {
                            Id = 51,
                            Name = "niğde"
                        },
                        new
                        {
                            Id = 52,
                            Name = "ordu"
                        },
                        new
                        {
                            Id = 53,
                            Name = "rize"
                        },
                        new
                        {
                            Id = 54,
                            Name = "sakarya"
                        },
                        new
                        {
                            Id = 55,
                            Name = "samsun"
                        },
                        new
                        {
                            Id = 56,
                            Name = "siirt"
                        },
                        new
                        {
                            Id = 57,
                            Name = "sinop"
                        },
                        new
                        {
                            Id = 58,
                            Name = "sivas"
                        },
                        new
                        {
                            Id = 59,
                            Name = "tekirdağ"
                        },
                        new
                        {
                            Id = 60,
                            Name = "tokat"
                        },
                        new
                        {
                            Id = 61,
                            Name = "trabzon"
                        },
                        new
                        {
                            Id = 62,
                            Name = "tunceli"
                        },
                        new
                        {
                            Id = 63,
                            Name = "şanlıurfa"
                        },
                        new
                        {
                            Id = 64,
                            Name = "uşak"
                        },
                        new
                        {
                            Id = 65,
                            Name = "van"
                        },
                        new
                        {
                            Id = 66,
                            Name = "yozgat"
                        },
                        new
                        {
                            Id = 67,
                            Name = "zonguldak"
                        },
                        new
                        {
                            Id = 68,
                            Name = "aksaray"
                        },
                        new
                        {
                            Id = 69,
                            Name = "bayburt"
                        },
                        new
                        {
                            Id = 70,
                            Name = "karaman"
                        },
                        new
                        {
                            Id = 71,
                            Name = "kırıkkale"
                        },
                        new
                        {
                            Id = 72,
                            Name = "batman"
                        },
                        new
                        {
                            Id = 73,
                            Name = "şırnak"
                        },
                        new
                        {
                            Id = 74,
                            Name = "bartın"
                        },
                        new
                        {
                            Id = 75,
                            Name = "ardahan"
                        },
                        new
                        {
                            Id = 76,
                            Name = "ığdır"
                        },
                        new
                        {
                            Id = 77,
                            Name = "yalova"
                        },
                        new
                        {
                            Id = 78,
                            Name = "karabük"
                        },
                        new
                        {
                            Id = 79,
                            Name = "kilis"
                        },
                        new
                        {
                            Id = 80,
                            Name = "osmaniye"
                        },
                        new
                        {
                            Id = 81,
                            Name = "düzce"
                        });
                });

            modelBuilder.Entity("CareerApp.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CareerApp.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "inşaat mühendisi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "yazılım geliştirici"
                        },
                        new
                        {
                            Id = 3,
                            Name = "doktor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "öğretmen"
                        },
                        new
                        {
                            Id = 5,
                            Name = "hemşire"
                        },
                        new
                        {
                            Id = 6,
                            Name = "avukat"
                        },
                        new
                        {
                            Id = 7,
                            Name = "mimar"
                        },
                        new
                        {
                            Id = 8,
                            Name = "eczacı"
                        },
                        new
                        {
                            Id = 9,
                            Name = "muhabir"
                        },
                        new
                        {
                            Id = 10,
                            Name = "elektrikçi"
                        },
                        new
                        {
                            Id = 11,
                            Name = "şef"
                        },
                        new
                        {
                            Id = 12,
                            Name = "grafiker"
                        },
                        new
                        {
                            Id = 13,
                            Name = "fotografçı"
                        },
                        new
                        {
                            Id = 14,
                            Name = "mekanikçi"
                        },
                        new
                        {
                            Id = 15,
                            Name = "tasarımcı"
                        },
                        new
                        {
                            Id = 16,
                            Name = "aşçı"
                        },
                        new
                        {
                            Id = 17,
                            Name = "müzik öğretmeni"
                        },
                        new
                        {
                            Id = 18,
                            Name = "itfaiyeci"
                        },
                        new
                        {
                            Id = 19,
                            Name = "bankacı"
                        },
                        new
                        {
                            Id = 20,
                            Name = "psikolog"
                        });
                });

            modelBuilder.Entity("CareerApp.Entities.JobPosting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ListingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Terms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobId");

                    b.ToTable("JobPostings");
                });

            modelBuilder.Entity("CareerApp.Entities.JobSeeker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("JobId");

                    b.HasIndex("RoleId");

                    b.ToTable("JobSeekers");
                });

            modelBuilder.Entity("CareerApp.Entities.Recourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("JobPostingId")
                        .HasColumnType("int");

                    b.Property<int?>("JobSeekerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecourseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobPostingId");

                    b.HasIndex("JobSeekerId");

                    b.ToTable("Recourses");
                });

            modelBuilder.Entity("CareerApp.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "company"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "jobSeeker"
                        },
                        new
                        {
                            Id = 3,
                            RoleName = "admin"
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

            modelBuilder.Entity("CareerApp.Entities.Company", b =>
                {
                    b.HasOne("CareerApp.Entities.Role", "Role")
                        .WithMany("Companies")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CareerApp.Entities.JobPosting", b =>
                {
                    b.HasOne("CareerApp.Entities.City", "City")
                        .WithMany("jobPostings")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerApp.Entities.Company", "Company")
                        .WithMany("JobPostings")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerApp.Entities.Job", "Job")
                        .WithMany("jobPostings")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Company");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("CareerApp.Entities.JobSeeker", b =>
                {
                    b.HasOne("CareerApp.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("CareerApp.Entities.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId");

                    b.HasOne("CareerApp.Entities.Role", "Role")
                        .WithMany("jobSeekers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Job");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CareerApp.Entities.Recourse", b =>
                {
                    b.HasOne("CareerApp.Entities.Company", "Company")
                        .WithMany("Recourses")
                        .HasForeignKey("CompanyId");

                    b.HasOne("CareerApp.Entities.JobPosting", "JobPosting")
                        .WithMany("Recourses")
                        .HasForeignKey("JobPostingId");

                    b.HasOne("CareerApp.Entities.JobSeeker", "JobSeeker")
                        .WithMany("Recourses")
                        .HasForeignKey("JobSeekerId");

                    b.Navigation("Company");

                    b.Navigation("JobPosting");

                    b.Navigation("JobSeeker");
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

            modelBuilder.Entity("CareerApp.Entities.City", b =>
                {
                    b.Navigation("jobPostings");
                });

            modelBuilder.Entity("CareerApp.Entities.Company", b =>
                {
                    b.Navigation("JobPostings");

                    b.Navigation("Recourses");
                });

            modelBuilder.Entity("CareerApp.Entities.Job", b =>
                {
                    b.Navigation("jobPostings");
                });

            modelBuilder.Entity("CareerApp.Entities.JobPosting", b =>
                {
                    b.Navigation("Recourses");
                });

            modelBuilder.Entity("CareerApp.Entities.JobSeeker", b =>
                {
                    b.Navigation("Recourses");
                });

            modelBuilder.Entity("CareerApp.Entities.Role", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("jobSeekers");
                });
#pragma warning restore 612, 618
        }
    }
}
