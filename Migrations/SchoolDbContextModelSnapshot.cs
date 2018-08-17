﻿// <auto-generated />
using CSVtoDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSVtoDB.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("CSVtoDB.School", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Age");

                    b.Property<double>("AverAge6");

                    b.Property<double>("AverAge7");

                    b.Property<double>("AverAge8");

                    b.Property<double>("AverAge9");

                    b.Property<double>("AverAgeX");

                    b.Property<double>("Distance");

                    b.Property<string>("District");

                    b.Property<string>("Division");

                    b.Property<string>("Level");

                    b.Property<double>("MFRatio");

                    b.Property<string>("MobileNum");

                    b.Property<string>("Name");

                    b.Property<double>("SES");

                    b.Property<double>("SEScore1");

                    b.Property<double>("SEScore2");

                    b.Property<double>("SEScore3");

                    b.Property<double>("SEScore4");

                    b.Property<string>("StreetAddr");

                    b.Property<double>("TSRatio");

                    b.Property<string>("Thana");

                    b.Property<string>("Type");

                    b.Property<string>("Union_Ward");

                    b.HasKey("ID");

                    b.ToTable("Schools");
                });
#pragma warning restore 612, 618
        }
    }
}
