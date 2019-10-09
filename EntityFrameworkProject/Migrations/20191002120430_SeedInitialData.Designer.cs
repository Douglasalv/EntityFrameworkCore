﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkProject.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191002120430_SeedInitialData")]
    partial class SeedInitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentId");

                    b.Property<int>("Age");

                    b.Property<Guid>("AnotherPrimaryKey");

                    b.Property<bool>("IsRegularStudent");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c796ea9a-2068-4d18-aea7-9b476cb23a4f"),
                            Age = 30,
                            AnotherPrimaryKey = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("ac710e1c-e030-4d77-9d41-cefefefee18c"),
                            Age = 25,
                            AnotherPrimaryKey = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "Jane Doe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}