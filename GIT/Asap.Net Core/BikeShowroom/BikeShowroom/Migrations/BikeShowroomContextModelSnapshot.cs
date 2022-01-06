﻿// <auto-generated />
using BikeShowroom.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BikeShowroom.Migrations
{
    [DbContext(typeof(BikeShowroomContext))]
    partial class BikeShowroomContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BikeShowroom.Models.Bikes", b =>
                {
                    b.Property<int>("BikeNums")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BikeModel")
                        .HasColumnType("int");

                    b.Property<string>("BikeNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BikeVerison")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BikeNums");

                    b.ToTable("Bikes");
                });
#pragma warning restore 612, 618
        }
    }
}