﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerce.Data;

#nullable disable

namespace ecommerce.Migrations
{
    [DbContext(typeof(AppDBcontext))]
    partial class AppDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ecommerce.Models.login", b =>
                {
                    b.Property<string>("uname")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("upass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uname");

                    b.ToTable("login");
                });
#pragma warning restore 612, 618
        }
    }
}
