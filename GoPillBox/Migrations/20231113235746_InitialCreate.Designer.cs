﻿// <auto-generated />
using System;
using GoPillBox.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GoPillBox.Migrations
{
    [DbContext(typeof(GoPillBoxDbContext))]
    [Migration("20231113235746_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GoPillBox.Models.AlarmEvent", b =>
                {
                    b.Property<int>("AlarmEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AlarmEventId"));

                    b.Property<int>("CurrentState")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EventTimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MedicationInTreatmentid")
                        .HasColumnType("integer");

                    b.Property<int>("PostponedForInMinutes")
                        .HasColumnType("integer");

                    b.HasKey("AlarmEventId");

                    b.ToTable("AlarmEvents");
                });

            modelBuilder.Entity("GoPillBox.Models.Medication", b =>
                {
                    b.Property<int>("MedicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MedicationId"));

                    b.Property<string[]>("Name")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("MedicationId");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("GoPillBox.Models.MedicationInTreatment", b =>
                {
                    b.Property<int>("MedicationInTreatmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MedicationInTreatmentId"));

                    b.Property<float>("Dose")
                        .HasColumnType("real");

                    b.Property<string>("DoseUnitOfMesure")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("DosingFrequencyInHours")
                        .HasColumnType("real");

                    b.Property<string>("MedicNotes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MedicationId")
                        .HasColumnType("integer");

                    b.Property<int>("TimeInTreatmentInDays")
                        .HasColumnType("integer");

                    b.Property<int>("TreatmentId")
                        .HasColumnType("integer");

                    b.HasKey("MedicationInTreatmentId");

                    b.ToTable("MedicationInTreatments");
                });

            modelBuilder.Entity("GoPillBox.Models.Treatment", b =>
                {
                    b.Property<int>("TreatmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TreatmentId"));

                    b.Property<string>("GeneralDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("TreatmentId");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("GoPillBox.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
