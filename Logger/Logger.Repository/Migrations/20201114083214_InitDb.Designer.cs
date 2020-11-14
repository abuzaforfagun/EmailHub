﻿// <auto-generated />
using System;
using Logger.Repository.Presistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Logger.Repository.Migrations
{
    [DbContext(typeof(LogDbContext))]
    [Migration("20201114083214_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Logger.Entities.EmailLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ReciverEmail")
                        .HasColumnType("text");

                    b.Property<DateTime>("SendOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SenderEmail")
                        .HasColumnType("text");

                    b.Property<string>("Subject")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmailLogs");
                });
#pragma warning restore 612, 618
        }
    }
}