﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220324133149_Update10.7")]
    partial class Update107
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.Concrete.Apply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUser")
                        .HasColumnType("int");

                    b.Property<int>("CvId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PostingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.HasIndex("PostingId");

                    b.HasIndex("UserId");

                    b.ToTable("Applies");
                });

            modelBuilder.Entity("Entities.Concrete.AuthorityTool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsModify")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWrite")
                        .HasColumnType("bit");

                    b.Property<int>("ToolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToolId");

                    b.ToTable("AuthorityTools");
                });

            modelBuilder.Entity("Entities.Concrete.CV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUser")
                        .HasColumnType("int");

                    b.Property<string>("CvPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CvPathName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CVs");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Countries")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Entities.Concrete.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DisciplineType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("Entities.Concrete.EmailConfirmed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmailConfirmedCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmailConfirmeds");
                });

            modelBuilder.Entity("Entities.Concrete.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateEvent")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventPhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventRemark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDeadLine")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateEvent")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Entities.Concrete.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUser")
                        .HasColumnType("int");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("PostingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("ImageTypeId");

                    b.HasIndex("PostingId");

                    b.HasIndex("UserId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Entities.Concrete.ImageType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ImageTypes");
                });

            modelBuilder.Entity("Entities.Concrete.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CallNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("Entities.Concrete.Posting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("Budget")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUser")
                        .HasColumnType("int");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FundingFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<bool>("ISFunded")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PostingTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostingTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quota")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Test")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("PostingTypeId");

                    b.HasIndex("TitleId");

                    b.HasIndex("UniversityId");

                    b.HasIndex("UserId");

                    b.ToTable("Postings");
                });

            modelBuilder.Entity("Entities.Concrete.PostingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PostingTypes");
                });

            modelBuilder.Entity("Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Entities.Concrete.SavedPosting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUser")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PostingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostingId");

                    b.HasIndex("UserId");

                    b.ToTable("SavedPostings");
                });

            modelBuilder.Entity("Entities.Concrete.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TitleType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("Entities.Concrete.Tool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUser")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ObjectController")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("Entities.Concrete.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUser")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUser")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Concrete.UserInterestedPosting", b =>
                {
                    b.Property<long>("Budget")
                        .HasColumnType("bigint");

                    b.Property<string>("DisciplineType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FundingFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<bool>("ISFunded")
                        .HasColumnType("bit");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quota")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TitleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.ToTable("UserInterestedPostings");
                });

            modelBuilder.Entity("Entities.Concrete.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Entities.Concrete.UserTool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ToolId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToolId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTools");
                });

            modelBuilder.Entity("Entities.Concrete.Individual", b =>
                {
                    b.HasBaseType("Entities.Concrete.User");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Experience")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitleAbbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotivationLetter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("TitleId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("Entities.Concrete.Institution", b =>
                {
                    b.HasBaseType("Entities.Concrete.User");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("Entities.Concrete.Apply", b =>
                {
                    b.HasOne("Entities.Concrete.CV", "CV")
                        .WithMany("Apply")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Posting", "Posting")
                        .WithMany("Applies")
                        .HasForeignKey("PostingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Applies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CV");

                    b.Navigation("Posting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.AuthorityTool", b =>
                {
                    b.HasOne("Entities.Concrete.Tool", "Tool")
                        .WithMany("AuthorityTool")
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tool");
                });

            modelBuilder.Entity("Entities.Concrete.CV", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("CVs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Entities.Concrete.EmailConfirmed", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("EmailConfirmeds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Event", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Image", b =>
                {
                    b.HasOne("Entities.Concrete.Event", "Event")
                        .WithMany("Image")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Concrete.ImageType", "ImageType")
                        .WithMany("Images")
                        .HasForeignKey("ImageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Posting", "Posting")
                        .WithMany("Images")
                        .HasForeignKey("PostingId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Image")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Event");

                    b.Navigation("ImageType");

                    b.Navigation("Posting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.PhoneNumber", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("PhoneNumber")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Posting", b =>
                {
                    b.HasOne("Entities.Concrete.Discipline", "Discipline")
                        .WithMany("Postings")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.PostingType", "PostingType")
                        .WithMany("Postings")
                        .HasForeignKey("PostingTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Title", "Title")
                        .WithMany("Postings")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.University", "University")
                        .WithMany("Posting")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Postings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("PostingType");

                    b.Navigation("Title");

                    b.Navigation("University");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.SavedPosting", b =>
                {
                    b.HasOne("Entities.Concrete.Posting", "Posting")
                        .WithMany("SavedPosting")
                        .HasForeignKey("PostingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("SavedPosting")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Posting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.University", b =>
                {
                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("Universities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.HasOne("Entities.Concrete.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Entities.Concrete.UserRole", b =>
                {
                    b.HasOne("Entities.Concrete.Role", "Role")
                        .WithMany("UsersRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("UserRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.UserTool", b =>
                {
                    b.HasOne("Entities.Concrete.Tool", "Tool")
                        .WithMany("UsersTool")
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("UserTool")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tool");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Individual", b =>
                {
                    b.HasOne("Entities.Concrete.Discipline", "Discipline")
                        .WithMany("Individuals")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Concrete.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrete.Individual", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Title", "Title")
                        .WithMany("Individuals")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Concrete.University", "University")
                        .WithMany("Individuals")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Discipline");

                    b.Navigation("Title");

                    b.Navigation("University");
                });

            modelBuilder.Entity("Entities.Concrete.Institution", b =>
                {
                    b.HasOne("Entities.Concrete.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrete.Institution", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.CV", b =>
                {
                    b.Navigation("Apply");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Universities");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Concrete.Discipline", b =>
                {
                    b.Navigation("Individuals");

                    b.Navigation("Postings");
                });

            modelBuilder.Entity("Entities.Concrete.Event", b =>
                {
                    b.Navigation("Image");
                });

            modelBuilder.Entity("Entities.Concrete.ImageType", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Entities.Concrete.Posting", b =>
                {
                    b.Navigation("Applies");

                    b.Navigation("Images");

                    b.Navigation("SavedPosting");
                });

            modelBuilder.Entity("Entities.Concrete.PostingType", b =>
                {
                    b.Navigation("Postings");
                });

            modelBuilder.Entity("Entities.Concrete.Role", b =>
                {
                    b.Navigation("UsersRole");
                });

            modelBuilder.Entity("Entities.Concrete.Title", b =>
                {
                    b.Navigation("Individuals");

                    b.Navigation("Postings");
                });

            modelBuilder.Entity("Entities.Concrete.Tool", b =>
                {
                    b.Navigation("AuthorityTool");

                    b.Navigation("UsersTool");
                });

            modelBuilder.Entity("Entities.Concrete.University", b =>
                {
                    b.Navigation("Individuals");

                    b.Navigation("Posting");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("Applies");

                    b.Navigation("CVs");

                    b.Navigation("EmailConfirmeds");

                    b.Navigation("Events");

                    b.Navigation("Image");

                    b.Navigation("PhoneNumber");

                    b.Navigation("Postings");

                    b.Navigation("SavedPosting");

                    b.Navigation("UserRole");

                    b.Navigation("UserTool");
                });
#pragma warning restore 612, 618
        }
    }
}
