﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCCSistema.Data;
using TCCSistema.Models;

namespace TCCSistema.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20210425025117_tcc_3")]
    partial class tcc_3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TCCSistema.Models.Camera", b =>
                {
                    b.Property<int>("id_camera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("camera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipadress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_camera");

                    b.ToTable("Camera");
                });

            modelBuilder.Entity("TCCSistema.Models.ImageLog", b =>
                {
                    b.Property<int>("id_image")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cameraid_camera")
                        .HasColumnType("int");

                    b.Property<int?>("Userid_user")
                        .HasColumnType("int");

                    b.Property<int>("frame_number")
                        .HasColumnType("int");

                    b.Property<int>("id_camera")
                        .HasColumnType("int");

                    b.Property<int>("id_user")
                        .HasColumnType("int");

                    b.Property<string>("image_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_string")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("position_h")
                        .HasColumnType("int");

                    b.Property<int>("position_v")
                        .HasColumnType("int");

                    b.Property<DateTime>("record")
                        .HasColumnType("datetime2");

                    b.HasKey("id_image");

                    b.HasIndex("Cameraid_camera");

                    b.HasIndex("Userid_user");

                    b.ToTable("ImageLog");
                });

            modelBuilder.Entity("TCCSistema.Models.Login", b =>
                {
                    b.Property<int>("id_login")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Userid_user")
                        .HasColumnType("int");

                    b.Property<int>("id_user")
                        .HasColumnType("int");

                    b.Property<string>("login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_login");

                    b.HasIndex("Userid_user");

                    b.ToTable("Login");

                    b.HasData(
                        new
                        {
                            id_login = 1,
                            id_user = 1,
                            login = "admin",
                            password = "admin"
                        });
                });

            modelBuilder.Entity("TCCSistema.Models.OccurrenceLog", b =>
                {
                    b.Property<int>("id_occurrence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cameraid_camera")
                        .HasColumnType("int");

                    b.Property<int?>("ImageLogid_image")
                        .HasColumnType("int");

                    b.Property<int?>("Userid_user")
                        .HasColumnType("int");

                    b.Property<int>("id_camera")
                        .HasColumnType("int");

                    b.Property<int>("id_image")
                        .HasColumnType("int");

                    b.Property<int>("id_user")
                        .HasColumnType("int");

                    b.Property<DateTime>("occurdate")
                        .HasColumnType("datetime2");

                    b.HasKey("id_occurrence");

                    b.HasIndex("Cameraid_camera");

                    b.HasIndex("ImageLogid_image");

                    b.HasIndex("Userid_user");

                    b.ToTable("OccurrenceLog");
                });

            modelBuilder.Entity("TCCSistema.Models.TargetUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("User1id_user")
                        .HasColumnType("int");

                    b.Property<int?>("User2id_user")
                        .HasColumnType("int");

                    b.Property<int>("id_user1")
                        .HasColumnType("int");

                    b.Property<int>("id_user2")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("User1id_user");

                    b.HasIndex("User2id_user");

                    b.ToTable("TargetUser");
                });

            modelBuilder.Entity("TCCSistema.Models.User", b =>
                {
                    b.Property<int>("id_user")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Loginid_login")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_user_type")
                        .HasColumnType("int");

                    b.Property<string>("info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isPatient")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_user");

                    b.HasIndex("Loginid_login");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            id_user = 1,
                            email = "admin@admin.com",
                            id_user_type = 1,
                            info = "System Administrator",
                            isPatient = false,
                            name = "Admin",
                            phone = "99999999"
                        });
                });

            modelBuilder.Entity("TCCSistema.Models.UserType", b =>
                {
                    b.Property<int>("id_user_type")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_user_type");

                    b.ToTable("UserType");

                    b.HasData(
                        new
                        {
                            id_user_type = 1,
                            type = "Administrator"
                        },
                        new
                        {
                            id_user_type = 2,
                            type = "Observer"
                        },
                        new
                        {
                            id_user_type = 3,
                            type = "Regular"
                        },
                        new
                        {
                            id_user_type = 4,
                            type = "Patient"
                        });
                });

            modelBuilder.Entity("TCCSistema.Models.ImageLog", b =>
                {
                    b.HasOne("TCCSistema.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("Cameraid_camera");

                    b.HasOne("TCCSistema.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid_user");

                    b.Navigation("Camera");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TCCSistema.Models.Login", b =>
                {
                    b.HasOne("TCCSistema.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TCCSistema.Models.OccurrenceLog", b =>
                {
                    b.HasOne("TCCSistema.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("Cameraid_camera");

                    b.HasOne("TCCSistema.Models.ImageLog", "ImageLog")
                        .WithMany()
                        .HasForeignKey("ImageLogid_image");

                    b.HasOne("TCCSistema.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid_user");

                    b.Navigation("Camera");

                    b.Navigation("ImageLog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TCCSistema.Models.TargetUser", b =>
                {
                    b.HasOne("TCCSistema.Models.User", "User1")
                        .WithMany()
                        .HasForeignKey("User1id_user");

                    b.HasOne("TCCSistema.Models.User", "User2")
                        .WithMany()
                        .HasForeignKey("User2id_user");

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("TCCSistema.Models.User", b =>
                {
                    b.HasOne("TCCSistema.Models.Login", null)
                        .WithMany("Users")
                        .HasForeignKey("Loginid_login");
                });

            modelBuilder.Entity("TCCSistema.Models.Login", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
