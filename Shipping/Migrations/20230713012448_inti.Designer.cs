﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shipping.Data;

#nullable disable

namespace Shipping.Migrations
{
    [DbContext(typeof(ShippingContext))]
    [Migration("20230713012448_inti")]
    partial class inti
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("Shipping.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
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

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("UserType").HasValue("ApplicationUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Shipping.Models.Branches", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id_city")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_city");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Shipping.Models.Cities", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Regular_Shipping")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Id_Governate");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Shipping.Models.Employee_Order", b =>
                {
                    b.Property<string>("Id_employee")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Order")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_employee", "Id_Order");

                    b.HasIndex("Id_Order");

                    b.ToTable("Employee_Orders");
                });

            modelBuilder.Entity("Shipping.Models.Governates", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Governates");
                });

            modelBuilder.Entity("Shipping.Models.Order", b =>
                {
                    b.Property<string>("Id_Order")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Client_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Branch")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_City")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Trader")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_representive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrderShippingTotalCost")
                        .HasColumnType("float");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<double>("ProductTotalCost")
                        .HasColumnType("float");

                    b.Property<string>("RepresentivesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SecondPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setting_WeightId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ShippingTypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Total_weight")
                        .HasColumnType("float");

                    b.Property<string>("VillageShippingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Village_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("flag_of_villagee")
                        .HasColumnType("bit");

                    b.Property<int>("orderStatus")
                        .HasColumnType("int");

                    b.HasKey("Id_Order");

                    b.HasIndex("Id_Branch")
                        .IsUnique()
                        .HasFilter("[Id_Branch] IS NOT NULL");

                    b.HasIndex("Id_City");

                    b.HasIndex("Id_Governate");

                    b.HasIndex("Id_Trader");

                    b.HasIndex("RepresentivesId");

                    b.HasIndex("Setting_WeightId");

                    b.HasIndex("ShippingTypeId");

                    b.HasIndex("VillageShippingId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Shipping.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Order")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Id_Order");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shipping.Models.Setting_Weight", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Extra_weight")
                        .HasColumnType("float");

                    b.Property<double>("weight_shipping")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Setting_Weights");
                });

            modelBuilder.Entity("Shipping.Models.Setting_shipping", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name_Of_Shipping")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number_Of_Days")
                        .HasColumnType("int");

                    b.Property<int>("Value_Of_shipping")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Setting_shippings");
                });

            modelBuilder.Entity("Shipping.Models.Special_Price_Trader", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Trader")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("Id_Governate");

                    b.HasIndex("Id_Trader");

                    b.HasIndex("Id_city");

                    b.ToTable("Special_Price_Traders");
                });

            modelBuilder.Entity("Shipping.Models.VillageShipping", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("VillageShippings");
                });

            modelBuilder.Entity("Shipping.Models.Employee", b =>
                {
                    b.HasBaseType("Shipping.Models.ApplicationUser");

                    b.Property<string>("Id_Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("Id_Branch");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("Shipping.Models.Representive", b =>
                {
                    b.HasBaseType("Shipping.Models.ApplicationUser");

                    b.Property<string>("Id_Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("company_percantage")
                        .HasColumnType("int");

                    b.Property<int>("type_of_discount")
                        .HasColumnType("int");

                    b.HasIndex("Id_Branch");

                    b.HasIndex("Id_Governate");

                    b.ToTable("AspNetUsers", t =>
                        {
                            t.Property("Id_Branch")
                                .HasColumnName("Representive_Id_Branch");
                        });

                    b.HasDiscriminator().HasValue("Representive");
                });

            modelBuilder.Entity("Shipping.Models.Trader", b =>
                {
                    b.HasBaseType("Shipping.Models.ApplicationUser");

                    b.Property<string>("Id_Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_City")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Governate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Per_Rejected_order")
                        .HasColumnType("float");

                    b.HasIndex("Id_Branch");

                    b.HasIndex("Id_City");

                    b.HasIndex("Id_Governate");

                    b.ToTable("AspNetUsers", t =>
                        {
                            t.Property("Id_Branch")
                                .HasColumnName("Trader_Id_Branch");

                            t.Property("Id_Governate")
                                .HasColumnName("Trader_Id_Governate");
                        });

                    b.HasDiscriminator().HasValue("Trader");
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
                    b.HasOne("Shipping.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Shipping.Models.ApplicationUser", null)
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

                    b.HasOne("Shipping.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Shipping.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shipping.Models.Branches", b =>
                {
                    b.HasOne("Shipping.Models.Cities", "city")
                        .WithMany("branches")
                        .HasForeignKey("Id_city");

                    b.Navigation("city");
                });

            modelBuilder.Entity("Shipping.Models.Cities", b =>
                {
                    b.HasOne("Shipping.Models.Governates", "governates")
                        .WithMany("cities")
                        .HasForeignKey("Id_Governate");

                    b.Navigation("governates");
                });

            modelBuilder.Entity("Shipping.Models.Employee_Order", b =>
                {
                    b.HasOne("Shipping.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Models.Employee", "employee")
                        .WithMany("Employee_Order")
                        .HasForeignKey("Id_employee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Shipping.Models.Order", b =>
                {
                    b.HasOne("Shipping.Models.Branches", "branches")
                        .WithOne("order")
                        .HasForeignKey("Shipping.Models.Order", "Id_Branch");

                    b.HasOne("Shipping.Models.Cities", "city")
                        .WithMany()
                        .HasForeignKey("Id_City");

                    b.HasOne("Shipping.Models.Governates", "Governates")
                        .WithMany()
                        .HasForeignKey("Id_Governate");

                    b.HasOne("Shipping.Models.Trader", "Trader")
                        .WithMany()
                        .HasForeignKey("Id_Trader");

                    b.HasOne("Shipping.Models.Representive", "Representives")
                        .WithMany()
                        .HasForeignKey("RepresentivesId");

                    b.HasOne("Shipping.Models.Setting_Weight", null)
                        .WithMany("order")
                        .HasForeignKey("Setting_WeightId");

                    b.HasOne("Shipping.Models.Setting_shipping", "ShippingType")
                        .WithMany("orders")
                        .HasForeignKey("ShippingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Models.VillageShipping", null)
                        .WithMany("Orders")
                        .HasForeignKey("VillageShippingId");

                    b.Navigation("Governates");

                    b.Navigation("Representives");

                    b.Navigation("ShippingType");

                    b.Navigation("Trader");

                    b.Navigation("branches");

                    b.Navigation("city");
                });

            modelBuilder.Entity("Shipping.Models.Product", b =>
                {
                    b.HasOne("Shipping.Models.Order", "order")
                        .WithMany("product")
                        .HasForeignKey("Id_Order");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Shipping.Models.Special_Price_Trader", b =>
                {
                    b.HasOne("Shipping.Models.Governates", "Governates")
                        .WithMany()
                        .HasForeignKey("Id_Governate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Models.Trader", "trader")
                        .WithMany()
                        .HasForeignKey("Id_Trader");

                    b.HasOne("Shipping.Models.Cities", "city")
                        .WithMany()
                        .HasForeignKey("Id_city")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governates");

                    b.Navigation("city");

                    b.Navigation("trader");
                });

            modelBuilder.Entity("Shipping.Models.Employee", b =>
                {
                    b.HasOne("Shipping.Models.Branches", "branches")
                        .WithMany("employees")
                        .HasForeignKey("Id_Branch")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("branches");
                });

            modelBuilder.Entity("Shipping.Models.Representive", b =>
                {
                    b.HasOne("Shipping.Models.Branches", "branches")
                        .WithMany("representive")
                        .HasForeignKey("Id_Branch")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Models.Governates", "Governates")
                        .WithMany("representive")
                        .HasForeignKey("Id_Governate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governates");

                    b.Navigation("branches");
                });

            modelBuilder.Entity("Shipping.Models.Trader", b =>
                {
                    b.HasOne("Shipping.Models.Branches", "branches")
                        .WithMany("traders")
                        .HasForeignKey("Id_Branch")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Models.Cities", "city")
                        .WithMany()
                        .HasForeignKey("Id_City")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Models.Governates", "Governates")
                        .WithMany()
                        .HasForeignKey("Id_Governate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governates");

                    b.Navigation("branches");

                    b.Navigation("city");
                });

            modelBuilder.Entity("Shipping.Models.Branches", b =>
                {
                    b.Navigation("employees");

                    b.Navigation("order");

                    b.Navigation("representive");

                    b.Navigation("traders");
                });

            modelBuilder.Entity("Shipping.Models.Cities", b =>
                {
                    b.Navigation("branches");
                });

            modelBuilder.Entity("Shipping.Models.Governates", b =>
                {
                    b.Navigation("cities");

                    b.Navigation("representive");
                });

            modelBuilder.Entity("Shipping.Models.Order", b =>
                {
                    b.Navigation("product");
                });

            modelBuilder.Entity("Shipping.Models.Setting_Weight", b =>
                {
                    b.Navigation("order");
                });

            modelBuilder.Entity("Shipping.Models.Setting_shipping", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("Shipping.Models.VillageShipping", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Shipping.Models.Employee", b =>
                {
                    b.Navigation("Employee_Order");
                });
#pragma warning restore 612, 618
        }
    }
}
