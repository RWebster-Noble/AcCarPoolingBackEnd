﻿// <auto-generated />
using System;
using AcCarPooling.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcCarPooling.Migrations
{
    [DbContext(typeof(CarPoolContext))]
    [Migration("20190118123855_initialcommit")]
    partial class initialcommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AcCarPooling.Models.Journey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Destination");

                    b.HasKey("Id");

                    b.ToTable("Journey");
                });

            modelBuilder.Entity("AcCarPooling.Models.LiftRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DriverId");

                    b.Property<int>("JourneyId");

                    b.Property<int>("PassengerId");

                    b.HasKey("Id");

                    b.HasIndex("JourneyId");

                    b.ToTable("LiftRequest");
                });

            modelBuilder.Entity("AcCarPooling.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department");

                    b.Property<string>("Email");

                    b.Property<string>("From");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsDriver");

                    b.Property<int?>("JourneyId");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("JourneyId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AcCarPooling.Models.LiftRequest", b =>
                {
                    b.HasOne("AcCarPooling.Models.Journey")
                        .WithMany("LiftRequests")
                        .HasForeignKey("JourneyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AcCarPooling.Models.User", b =>
                {
                    b.HasOne("AcCarPooling.Models.Journey", "Journey")
                        .WithMany("Passengers")
                        .HasForeignKey("JourneyId");
                });
#pragma warning restore 612, 618
        }
    }
}
