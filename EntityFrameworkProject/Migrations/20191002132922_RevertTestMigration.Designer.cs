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
    [Migration("20191002132922_RevertTestMigration")]
    partial class RevertTestMigration
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

                    b.Property<bool>("IsRegularStudent")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2688f902-946e-4254-820f-dc759094c3b5"),
                            Age = 30,
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("47bd0b6d-0a7a-4ec5-9e1e-56b28173ff7b"),
                            Age = 25,
                            IsRegularStudent = false,
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = new Guid("bdf30d61-c574-49c1-abb9-57ae08f1c078"),
                            Age = 28,
                            IsRegularStudent = false,
                            Name = "Mike Miles"
                        },
                        new
                        {
                            Id = new Guid("e545df0f-08a0-4b99-b62f-73f9cf557e8e"),
                            Age = 100,
                            IsRegularStudent = false,
                            Name = "TEST Name"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}