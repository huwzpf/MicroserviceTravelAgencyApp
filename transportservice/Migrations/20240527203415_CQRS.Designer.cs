﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using transportservice.Models;

#nullable disable

namespace transportservice.Migrations
{
    [DbContext(typeof(TransportDbContext))]
    [Migration("20240527203415_CQRS")]
    partial class CQRS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("transportservice.Models.CommandTransportOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FromCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FromCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FromShowName")
                        .HasColumnType("text");

                    b.Property<string>("FromStreet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("InitialSeats")
                        .HasColumnType("integer");

                    b.Property<decimal>("PriceAdult")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PriceUnder10")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PriceUnder18")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PriceUnder3")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ToCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ToCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ToShowName")
                        .HasColumnType("text");

                    b.Property<string>("ToStreet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CommandTransportOptions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9cdbc293-27f7-4de1-a23d-05a548f25442"),
                            End = new DateTime(2024, 5, 28, 22, 34, 14, 937, DateTimeKind.Utc).AddTicks(9347),
                            FromCity = "Paris",
                            FromCountry = "France",
                            FromStreet = "Charles de Gaulle",
                            InitialSeats = 100,
                            PriceAdult = 150m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Start = new DateTime(2024, 5, 28, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9337),
                            ToCity = "Berlin",
                            ToCountry = "Germany",
                            ToStreet = "Tegel",
                            Type = "Plane"
                        },
                        new
                        {
                            Id = new Guid("7d5b901c-bd58-4aba-aa53-4aecf56781fa"),
                            End = new DateTime(2024, 6, 2, 1, 34, 14, 937, DateTimeKind.Utc).AddTicks(9356),
                            FromCity = "Berlin",
                            FromCountry = "Germany",
                            FromStreet = "Tegel",
                            InitialSeats = 100,
                            PriceAdult = 150m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Start = new DateTime(2024, 6, 1, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9356),
                            ToCity = "Paris",
                            ToCountry = "France",
                            ToStreet = "Charles de Gaulle",
                            Type = "Plane"
                        },
                        new
                        {
                            Id = new Guid("b7576fc8-f86e-4bbc-bc50-e6177d3f2920"),
                            End = new DateTime(2024, 5, 29, 6, 34, 14, 937, DateTimeKind.Utc).AddTicks(9361),
                            FromCity = "Tokyo",
                            FromCountry = "Japan",
                            FromStreet = "Narita",
                            InitialSeats = 150,
                            PriceAdult = 500m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Start = new DateTime(2024, 5, 28, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9361),
                            ToCity = "Gdansk",
                            ToCountry = "Poland",
                            ToStreet = "Lech Walesa",
                            Type = "Plane"
                        },
                        new
                        {
                            Id = new Guid("c52ad295-b949-4203-89c0-4781c88f6cbf"),
                            End = new DateTime(2024, 6, 11, 6, 34, 14, 937, DateTimeKind.Utc).AddTicks(9365),
                            FromCity = "Gdansk",
                            FromCountry = "Poland",
                            FromStreet = "Lech Walesa",
                            InitialSeats = 150,
                            PriceAdult = 500m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Start = new DateTime(2024, 6, 10, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9364),
                            ToCity = "Tokyo",
                            ToCountry = "Japan",
                            ToStreet = "Narita",
                            Type = "Plane"
                        },
                        new
                        {
                            Id = new Guid("16bf195b-a751-412a-9532-63b173212889"),
                            End = new DateTime(2024, 5, 30, 22, 34, 14, 937, DateTimeKind.Utc).AddTicks(9368),
                            FromCity = "London",
                            FromCountry = "UK",
                            FromStreet = "Heathrow",
                            InitialSeats = 120,
                            PriceAdult = 200m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Start = new DateTime(2024, 5, 30, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9367),
                            ToCity = "Gdansk",
                            ToCountry = "Poland",
                            ToStreet = "Lech Walesa",
                            Type = "Plane"
                        });
                });

            modelBuilder.Entity("transportservice.Models.Discount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TransportOptionId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("TransportOptionId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("transportservice.Models.QueryTransportOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FromCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FromCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FromShowName")
                        .HasColumnType("text");

                    b.Property<string>("FromStreet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PriceAdult")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PriceUnder10")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PriceUnder18")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PriceUnder3")
                        .HasColumnType("numeric");

                    b.Property<int>("Seats")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ToCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ToCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ToShowName")
                        .HasColumnType("text");

                    b.Property<string>("ToStreet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QueryTransportOptions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9cdbc293-27f7-4de1-a23d-05a548f25442"),
                            End = new DateTime(2024, 5, 28, 22, 34, 14, 937, DateTimeKind.Utc).AddTicks(9629),
                            FromCity = "Paris",
                            FromCountry = "France",
                            FromStreet = "Charles de Gaulle",
                            PriceAdult = 150m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Seats = 100,
                            Start = new DateTime(2024, 5, 28, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9627),
                            ToCity = "Berlin",
                            ToCountry = "Germany",
                            ToStreet = "Tegel",
                            Type = "Plane"
                        },
                        new
                        {
                            Id = new Guid("7d5b901c-bd58-4aba-aa53-4aecf56781fa"),
                            End = new DateTime(2024, 6, 2, 1, 34, 14, 937, DateTimeKind.Utc).AddTicks(9634),
                            FromCity = "Berlin",
                            FromCountry = "Germany",
                            FromStreet = "Tegel",
                            PriceAdult = 150m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Seats = 100,
                            Start = new DateTime(2024, 6, 1, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9634),
                            ToCity = "Paris",
                            ToCountry = "France",
                            ToStreet = "Charles de Gaulle",
                            Type = "Plane"
                        },
                        new
                        {
                            Id = new Guid("b7576fc8-f86e-4bbc-bc50-e6177d3f2920"),
                            End = new DateTime(2024, 5, 29, 6, 34, 14, 937, DateTimeKind.Utc).AddTicks(9640),
                            FromCity = "Tokyo",
                            FromCountry = "Japan",
                            FromStreet = "Narita",
                            PriceAdult = 500m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Seats = 150,
                            Start = new DateTime(2024, 5, 28, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9639),
                            ToCity = "Gdansk",
                            ToCountry = "Poland",
                            ToStreet = "Lech Walesa",
                            Type = "Plane"
                        },
                        new
                        {
                            Id = new Guid("c52ad295-b949-4203-89c0-4781c88f6cbf"),
                            End = new DateTime(2024, 6, 11, 6, 34, 14, 937, DateTimeKind.Utc).AddTicks(9642),
                            FromCity = "Gdansk",
                            FromCountry = "Poland",
                            FromStreet = "Lech Walesa",
                            PriceAdult = 500m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Seats = 150,
                            Start = new DateTime(2024, 6, 10, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9642),
                            ToCity = "Tokyo",
                            ToCountry = "Japan",
                            ToStreet = "Narita",
                            Type = "Plane"
                        },
                        new
                        {
                            Id = new Guid("16bf195b-a751-412a-9532-63b173212889"),
                            End = new DateTime(2024, 5, 30, 22, 34, 14, 937, DateTimeKind.Utc).AddTicks(9645),
                            FromCity = "London",
                            FromCountry = "UK",
                            FromStreet = "Heathrow",
                            PriceAdult = 200m,
                            PriceUnder10 = 0m,
                            PriceUnder18 = 0m,
                            PriceUnder3 = 0m,
                            Seats = 120,
                            Start = new DateTime(2024, 5, 30, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9645),
                            ToCity = "Gdansk",
                            ToCountry = "Poland",
                            ToStreet = "Lech Walesa",
                            Type = "Plane"
                        });
                });

            modelBuilder.Entity("transportservice.Models.SeatsChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("ChangeBy")
                        .HasColumnType("integer");

                    b.Property<Guid>("TransportOptionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TransportOptionId");

                    b.ToTable("SeatsChanges");
                });

            modelBuilder.Entity("transportservice.Models.Discount", b =>
                {
                    b.HasOne("transportservice.Models.CommandTransportOption", null)
                        .WithMany("Discounts")
                        .HasForeignKey("TransportOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("transportservice.Models.SeatsChange", b =>
                {
                    b.HasOne("transportservice.Models.CommandTransportOption", null)
                        .WithMany("SeatsChanges")
                        .HasForeignKey("TransportOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("transportservice.Models.CommandTransportOption", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("SeatsChanges");
                });
#pragma warning restore 612, 618
        }
    }
}
