﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactNativeApi.Context;

#nullable disable

namespace ReactNativeApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250410213125_mg13443")]
    partial class mg13443
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReactNativeApi.Models.TableOne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DgtParcaKodu")
                        .HasColumnType("int");

                    b.Property<DateTime>("DosyaAcilmaSaatTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("DosyaYukle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kaydet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjeAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjeSorumlusu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SorumluKisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SureGun")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("UretimAdeti")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TableOnes");
                });

            modelBuilder.Entity("ReactNativeApi.Models.TableThree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("TableThrees");
                });

            modelBuilder.Entity("ReactNativeApi.Models.TableTwo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AciklamaListesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BeklemedeAdet")
                        .HasColumnType("int");

                    b.Property<string>("DgtParcaKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OnaylayanProjeYoneticisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TableThreeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeknisyenAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TableThreeId");

                    b.ToTable("TableTwos");
                });

            modelBuilder.Entity("ReactNativeApi.Models.TableTwo", b =>
                {
                    b.HasOne("ReactNativeApi.Models.TableThree", null)
                        .WithMany("UygunsuzlukTespitListesi")
                        .HasForeignKey("TableThreeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReactNativeApi.Models.TableThree", b =>
                {
                    b.Navigation("UygunsuzlukTespitListesi");
                });
#pragma warning restore 612, 618
        }
    }
}
