﻿// <auto-generated />
using System;
using Ferramas.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ferramas.Migrations
{
    [DbContext(typeof(FerraContext))]
    [Migration("20240503144436_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ferramas.Model.Domain.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Ferramas.Model.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Comestibles / Cocina"
                        },
                        new
                        {
                            Id = 2,
                            Name = "DecoHogar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pasatiempos"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tecnología"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Construcción"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Moda"
                        });
                });

            modelBuilder.Entity("Ferramas.Model.Domain.FerraUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2032f322-70d2-4532-9219-f598158b7b68"),
                            Email = "testerina@gmail.com",
                            Name = "Testerina",
                            PasswordHash = "admin",
                            Surname = "Tester"
                        },
                        new
                        {
                            Id = new Guid("9dcedf4a-3e48-4626-ad61-31056c6ab39d"),
                            Email = "acasas@gmail.com",
                            Name = "Armando",
                            PasswordHash = "admin",
                            Surname = "Casas"
                        },
                        new
                        {
                            Id = new Guid("27fadd5d-b1a7-49e8-aa26-24be2de4306d"),
                            Email = "pe.palo@gmail.com",
                            Name = "Pedro",
                            PasswordHash = "admin",
                            Surname = "Palote"
                        });
                });

            modelBuilder.Entity("Ferramas.Model.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ecfb1b24-5c71-4143-92a7-f8bd09514866"),
                            CategoryId = 1,
                            Description = "Para hacerte el hipster y decir que cocinas todo con agua.",
                            Name = "Aceite en Polvo",
                            Price = 6500f
                        },
                        new
                        {
                            Id = new Guid("c99fcbb9-4d7d-4871-8637-ccf188b6f6a8"),
                            CategoryId = 2,
                            Description = "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.",
                            Name = "Látigo con Puntas de Cobre",
                            Price = 13250f
                        },
                        new
                        {
                            Id = new Guid("e8a6381b-79bf-4f79-8e93-eef375c84bc6"),
                            CategoryId = 2,
                            Description = "Sancho Panza Metálico.",
                            Name = "Figura de Fierro de Don Quijote",
                            Price = 23250f
                        },
                        new
                        {
                            Id = new Guid("3a21388c-9101-464e-8a64-a097c97911be"),
                            CategoryId = 3,
                            Description = "Para disfrazarte de alguien que se cree impuro.",
                            Name = "Látigo con Puntas Sin Filo",
                            Price = 10250f
                        },
                        new
                        {
                            Id = new Guid("0c7e6a1a-3086-4ece-b69e-3f71586f6b21"),
                            CategoryId = 4,
                            Description = "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.",
                            Name = "Multiantena de Fierro",
                            Price = 6350f
                        },
                        new
                        {
                            Id = new Guid("61981998-495f-4fc6-8220-ab40a9d9df17"),
                            CategoryId = 5,
                            Description = "Para mostrar la fuerza que no tienes.",
                            Name = "Martillo Doble Golpe",
                            Price = 7360f
                        },
                        new
                        {
                            Id = new Guid("09e88bcc-f02d-4ca7-81e0-9eaa0a02ce5c"),
                            CategoryId = 6,
                            Description = "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.",
                            Name = "Miembro a Escala",
                            Price = 7360f
                        });
                });

            modelBuilder.Entity("Ferramas.Model.Domain.PurchaseAttempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AttemptDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("PurchasePrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Ferramas.Model.Domain.Cart", b =>
                {
                    b.HasOne("Ferramas.Model.Domain.FerraUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ferramas.Model.Domain.Product", b =>
                {
                    b.HasOne("Ferramas.Model.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ferramas.Model.Domain.PurchaseAttempt", b =>
                {
                    b.HasOne("Ferramas.Model.Domain.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cart");
                });
#pragma warning restore 612, 618
        }
    }
}
