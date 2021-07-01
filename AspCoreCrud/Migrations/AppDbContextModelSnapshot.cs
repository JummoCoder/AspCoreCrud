﻿// <auto-generated />
using AspCoreCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspCoreCrud.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspCoreCrud.Models.tblColdDrink", b =>
                {
                    b.Property<int>("intColdDrinksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("numQuantity")
                        .HasColumnType("float");

                    b.Property<double>("numUnitPrice")
                        .HasColumnType("float");

                    b.Property<string>("strColdDrinksName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("intColdDrinksId");

                    b.ToTable("tblColdDrinks");
                });
#pragma warning restore 612, 618
        }
    }
}