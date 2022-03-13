﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFinanceCore5_SQLServer.Data;

namespace MyFinanceCore5_SQLServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220313164558_upadate_user")]
    partial class upadate_user
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.CardUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("CardUsers");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.FixedBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeFixedBillId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeFixedBillId");

                    b.HasIndex("UserId");

                    b.ToTable("FixedBill");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Input", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TypeInputId")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TypeInputId");

                    b.HasIndex("UserID");

                    b.ToTable("Inputs");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.InstallmentBuy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfInstallment")
                        .HasColumnType("int");

                    b.Property<double>("PriceInstallment")
                        .HasColumnType("float");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("InstallmentBuys");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.InstallmentTypeInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InputId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfInstallment")
                        .HasColumnType("int");

                    b.Property<double>("PriceOfInstallment")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InputId");

                    b.ToTable("InstallmentTypeInputs");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypePaymentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypePaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.PictureIcon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PictureIcons");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePurchase")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardUserId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypeFixedBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("TypeFixedBills");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypeInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("TypeInputs");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypePayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FlagCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PictureIconId")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PictureIconId");

                    b.HasIndex("UserID");

                    b.ToTable("TypePayments");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.CardUser", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.User", "User")
                        .WithMany("CardUsers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.FixedBill", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.TypeFixedBill", "TypeFixedBill")
                        .WithMany("FixedBills")
                        .HasForeignKey("TypeFixedBillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.User", "User")
                        .WithMany("FixedBills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeFixedBill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Input", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.TypeInput", "TypeInput")
                        .WithMany("Inputs")
                        .HasForeignKey("TypeInputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeInput");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.InstallmentBuy", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.Shop", "Shop")
                        .WithMany("InstallmentBuys")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.InstallmentTypeInput", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.Input", "Input")
                        .WithMany("InstallmentTypeInput")
                        .HasForeignKey("InputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Input");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Payment", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.TypePayment", "TypePayment")
                        .WithMany("Payments")
                        .HasForeignKey("TypePaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypePayment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Shop", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.CardUser", "CardUser")
                        .WithMany()
                        .HasForeignKey("CardUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.Payment", "Payment")
                        .WithMany("Shops")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.User", "User")
                        .WithMany("Shops")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardUser");

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypeFixedBill", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.User", "User")
                        .WithMany("TypeFixedBills")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypeInput", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.User", "User")
                        .WithMany("TypeInputs")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypePayment", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.PictureIcon", "PictureIcon")
                        .WithMany("TypePayments")
                        .HasForeignKey("PictureIconId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.User", "User")
                        .WithMany("TypePayments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PictureIcon");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.User", b =>
                {
                    b.HasOne("MyFinanceCore5_SQLServer.Models.Entity.Profile", "Profile")
                        .WithMany("Users")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Input", b =>
                {
                    b.Navigation("InstallmentTypeInput");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Payment", b =>
                {
                    b.Navigation("Shops");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.PictureIcon", b =>
                {
                    b.Navigation("TypePayments");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Profile", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.Shop", b =>
                {
                    b.Navigation("InstallmentBuys");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypeFixedBill", b =>
                {
                    b.Navigation("FixedBills");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypeInput", b =>
                {
                    b.Navigation("Inputs");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.TypePayment", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("MyFinanceCore5_SQLServer.Models.Entity.User", b =>
                {
                    b.Navigation("CardUsers");

                    b.Navigation("FixedBills");

                    b.Navigation("Shops");

                    b.Navigation("TypeFixedBills");

                    b.Navigation("TypeInputs");

                    b.Navigation("TypePayments");
                });
#pragma warning restore 612, 618
        }
    }
}