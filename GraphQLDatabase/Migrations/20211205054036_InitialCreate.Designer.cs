﻿// <auto-generated />
using GraphQLDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GraphQLDatabase.Migrations
{
    [DbContext(typeof(DemoContext))]
    [Migration("20211205054036_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GraphQLDatabase.Movie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Actors")
                        .HasColumnType("text");

                    b.Property<string>("Director")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Released")
                        .HasColumnType("text");

                    b.Property<string>("Writers")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Actors = "Martin Corsezi",
                            Director = "Joel Shoemacker",
                            Name = "Intestellar",
                            Released = "2021-02-03",
                            Writers = "Some Writer"
                        },
                        new
                        {
                            Id = 2L,
                            Actors = "Keanu Reeves",
                            Director = "Lana Wachowski",
                            Name = "The Matrix",
                            Released = "2021-02-03",
                            Writers = "Some Writer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
