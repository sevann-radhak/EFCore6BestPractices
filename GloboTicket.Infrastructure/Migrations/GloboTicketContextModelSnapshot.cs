﻿// <auto-generated />
using System;
using GloboTicket.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GloboTicket.Infrastructure.Migrations
{
    [DbContext(typeof(GloboTicketContext))]
    partial class GloboTicketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GloboTicket.Domain.Entities.Act", b =>
                {
                    b.Property<int>("ActId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActId"), 1L, 1);

                    b.Property<Guid>("ActGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ActId");

                    b.HasAlternateKey("ActGuid");

                    b.ToTable("Act");
                });

            modelBuilder.Entity("GloboTicket.Domain.Entities.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowId"), 1L, 1);

                    b.Property<int>("ActId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ShowGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("ShowId");

                    b.HasAlternateKey("ShowGuid");

                    b.HasIndex("ActId");

                    b.HasIndex("VenueId");

                    b.ToTable("Show");
                });

            modelBuilder.Entity("GloboTicket.Domain.Entities.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("VenueGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VenueId");

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("GloboTicket.Domain.Entities.Show", b =>
                {
                    b.HasOne("GloboTicket.Domain.Entities.Act", "Act")
                        .WithMany()
                        .HasForeignKey("ActId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GloboTicket.Domain.Entities.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Act");

                    b.Navigation("Venue");
                });
#pragma warning restore 612, 618
        }
    }
}
