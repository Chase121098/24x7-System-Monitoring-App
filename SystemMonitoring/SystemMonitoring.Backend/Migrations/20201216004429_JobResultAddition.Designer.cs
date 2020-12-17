﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SystemMonitoring.Backend.Data;

namespace SystemMonitoring.Backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201216004429_JobResultAddition")]
    partial class JobResultAddition
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SystemMonitoring.Backend.Models.JobResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TotalFailedJobs")
                        .HasColumnType("integer");

                    b.Property<int>("TotalJobs")
                        .HasColumnType("integer");

                    b.Property<int>("TotalSuccessfulJobs")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("JobResults");
                });

            modelBuilder.Entity("SystemMonitoring.Backend.Models.TestForHangfire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Job")
                        .HasColumnType("text");

                    b.Property<string>("RunTime")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TestForHangfire");
                });
#pragma warning restore 612, 618
        }
    }
}
