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
    [Migration("20240526011922_Productss")]
    partial class Productss
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

                    b.Property<bool>("PurchasePending")
                        .HasColumnType("bit");

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
                            Id = new Guid("cb8c5393-ca1e-4f02-bf9e-a5228800e723"),
                            Email = "testerina@gmail.com",
                            Name = "Testerina",
                            PasswordHash = "admin",
                            Surname = "Tester"
                        },
                        new
                        {
                            Id = new Guid("f999fdf7-3060-433c-bb55-a1647d3ea990"),
                            Email = "acasas@gmail.com",
                            Name = "Armando",
                            PasswordHash = "admin",
                            Surname = "Casas"
                        },
                        new
                        {
                            Id = new Guid("d28bd27c-46f6-45ab-9584-e26d328c1fca"),
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

                    b.Property<string>("Image")
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
                            Id = new Guid("990a6c62-bde9-460e-9984-a3e7c26d3f96"),
                            CategoryId = 1,
                            Description = "Para hacerte el hipster y decir que cocinas todo con agua.",
                            Image = "aceite.jpg",
                            Name = "Aceite en Polvo",
                            Price = 6500f
                        },
                        new
                        {
                            Id = new Guid("43205b8c-c233-484a-b583-a0db07c1abdb"),
                            CategoryId = 1,
                            Description = "Para evitar la sal",
                            Name = "Sal sin sodio",
                            Price = 1200f
                        },
                        new
                        {
                            Id = new Guid("69034056-9fd5-4407-8f4f-f8d93a1163f1"),
                            CategoryId = 1,
                            Description = "Nose porque diablos alguien compraria esto",
                            Name = "NOT MAYO",
                            Price = 3500f
                        },
                        new
                        {
                            Id = new Guid("5a614efe-01a8-4825-afc4-2d5511265e82"),
                            CategoryId = 2,
                            Description = "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.",
                            Name = "Látigo con Puntas de Cobre",
                            Price = 13250f
                        },
                        new
                        {
                            Id = new Guid("aee40fa5-74ff-478c-b644-06dc9d2c8eca"),
                            CategoryId = 2,
                            Description = "Para hacer el pan de los dioses",
                            Name = "Tostador chileno",
                            Price = 5000f
                        },
                        new
                        {
                            Id = new Guid("5461ae64-623b-42bd-a9fc-afc33f168f1f"),
                            CategoryId = 2,
                            Description = "La ventana ideal",
                            Name = "Ventana de hielo 7",
                            Price = 1000f
                        },
                        new
                        {
                            Id = new Guid("858bb151-a1e6-4a5c-9aa6-d66d72e59a6a"),
                            CategoryId = 3,
                            Description = "Para disfrazarte de alguien que se cree impuro.",
                            Name = "Látigo con Puntas Sin Filo",
                            Price = 10250f
                        },
                        new
                        {
                            Id = new Guid("4764efa6-4206-44ac-838d-a78525ddd3ab"),
                            CategoryId = 3,
                            Description = "Creeme es una buena compra",
                            Name = "Diccionario para entender a las mujeres",
                            Price = 7500f
                        },
                        new
                        {
                            Id = new Guid("d2ee9f6c-26c4-4fb3-b120-2fc6671e41cb"),
                            CategoryId = 3,
                            Description = "La pelota de quico finalmente ha llgeaod al mercado",
                            Name = "Pelota cuadrada",
                            Price = 2000f
                        },
                        new
                        {
                            Id = new Guid("594c0f1e-81d0-44b6-b39e-c33b98e661ea"),
                            CategoryId = 4,
                            Description = "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.",
                            Name = "Multiantena de Fierro",
                            Price = 6350f
                        },
                        new
                        {
                            Id = new Guid("914ac68a-ccd8-4526-8823-c0d68ddb2ef8"),
                            CategoryId = 4,
                            Description = "Finge estatus pero con algo de cerebro",
                            Name = "Iphone con bateria incluida",
                            Price = 1000000f
                        },
                        new
                        {
                            Id = new Guid("3d66baca-25d8-4fcf-8636-48c89b0fdbdb"),
                            CategoryId = 4,
                            Description = "Un televisor invisible,no hay mas descripcion",
                            Name = "Television invisible",
                            Price = 256000f
                        },
                        new
                        {
                            Id = new Guid("a996a696-a27d-4962-92df-dbae7dce8011"),
                            CategoryId = 5,
                            Description = "Para mostrar la fuerza que no tienes.",
                            Name = "Martillo Doble Golpe",
                            Price = 7360f
                        },
                        new
                        {
                            Id = new Guid("72b14fe5-5bae-44f3-8814-8bcac0b008a9"),
                            CategoryId = 5,
                            Description = "Ideal para construir aeroplanos",
                            Name = "Cable inalambrico",
                            Price = 6000f
                        },
                        new
                        {
                            Id = new Guid("65c88822-858f-4594-be91-672bf09ecf52"),
                            CategoryId = 5,
                            Description = "En el pais no existe",
                            Name = "Cadena perpetua",
                            Price = 9000f
                        },
                        new
                        {
                            Id = new Guid("3825b94a-0c39-44a4-80da-0aec043148ca"),
                            CategoryId = 6,
                            Description = "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.",
                            Name = "Miembro a Escala",
                            Price = 7360f
                        },
                        new
                        {
                            Id = new Guid("c8e418d7-7930-44c5-a1ba-da65de410674"),
                            CategoryId = 6,
                            Description = "Regalalo",
                            Name = "Cosplay de enfermera",
                            Price = 4990f
                        },
                        new
                        {
                            Id = new Guid("619aa464-0f71-42e0-9bbb-426e6720ab98"),
                            CategoryId = 6,
                            Description = "Ropa de mal gusto",
                            Name = "Ropa de mal gusto",
                            Price = 10f
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

                    b.Property<string>("TransbankSession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Ferramas.Model.Domain.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Subscriptions");
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