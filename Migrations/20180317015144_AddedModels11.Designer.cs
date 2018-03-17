﻿// <auto-generated />
using GradeProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace GradeProject.Migrations
{
    [DbContext(typeof(GradeContext))]
    [Migration("20180317015144_AddedModels11")]
    partial class AddedModels11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GradeProject.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssignmentClass");

                    b.Property<int>("AssignmentGrade");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("StudentId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Assignment");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Assignment");
                });

            modelBuilder.Entity("GradeProject.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Major");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("GradeProject.Models.Homework", b =>
                {
                    b.HasBaseType("GradeProject.Models.Assignment");


                    b.ToTable("Homework");

                    b.HasDiscriminator().HasValue("Homework");
                });

            modelBuilder.Entity("GradeProject.Models.Test", b =>
                {
                    b.HasBaseType("GradeProject.Models.Assignment");


                    b.ToTable("Test");

                    b.HasDiscriminator().HasValue("Test");
                });

            modelBuilder.Entity("GradeProject.Models.Assignment", b =>
                {
                    b.HasOne("GradeProject.Models.Student", "Student")
                        .WithMany("Assignments")
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
