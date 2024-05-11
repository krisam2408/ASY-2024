using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class CartStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26f23bec-2855-4675-8fb9-eb20a2619b62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31f3550b-7c05-46d9-9d87-9143e334b81c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68367bc2-3386-444e-b536-113991ceaf62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87cd4682-f5fa-4843-bc3e-4f758ca378ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bfffc66-e36d-4c2a-8b4b-782095d57ebd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c467ff12-6fbd-484e-b607-06686695aaea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d99d7cc2-a736-41d0-ac13-145e3933bdda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07142810-eb41-4892-9e92-1bcf5f6c3c19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c2fda0e-cff5-43fb-a26a-ee67ceb38a73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7c6ad17-f6ac-46c0-9927-0c0c3c5be309"));

            migrationBuilder.AddColumn<bool>(
                name: "PurchasePending",
                table: "Cart",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0a5c2c44-8df3-4a6d-8ac0-5e0688ea6e7d"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f },
                    { new Guid("13a05a73-4ea8-492b-88b5-1b8a17447481"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f },
                    { new Guid("32aaba95-7457-4777-ac33-be88a7a9a96c"), 2, "Sancho Panza Metálico.", null, "Figura de Fierro de Don Quijote", 23250f },
                    { new Guid("48642c10-ddaf-4502-94ba-d218abdc1bee"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", null, "Aceite en Polvo", 6500f },
                    { new Guid("aa39aa99-f9f4-4913-8869-4f4c31501300"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("bc5f6652-5878-4047-a5ce-004738fcfbc3"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f },
                    { new Guid("f3eff7ae-9793-447d-91ba-02a72e190b29"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("4369cb68-9b92-47eb-b09c-943517847b6a"), "acasas@gmail.com", "Armando", "admin", "Casas" },
                    { new Guid("62f68b59-7687-438d-9efb-0f5ea25d4932"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("cb3aa4c5-103e-4af5-9a99-2c40c05b825d"), "testerina@gmail.com", "Testerina", "admin", "Tester" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a5c2c44-8df3-4a6d-8ac0-5e0688ea6e7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13a05a73-4ea8-492b-88b5-1b8a17447481"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32aaba95-7457-4777-ac33-be88a7a9a96c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48642c10-ddaf-4502-94ba-d218abdc1bee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa39aa99-f9f4-4913-8869-4f4c31501300"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc5f6652-5878-4047-a5ce-004738fcfbc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3eff7ae-9793-447d-91ba-02a72e190b29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4369cb68-9b92-47eb-b09c-943517847b6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62f68b59-7687-438d-9efb-0f5ea25d4932"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb3aa4c5-103e-4af5-9a99-2c40c05b825d"));

            migrationBuilder.DropColumn(
                name: "PurchasePending",
                table: "Cart");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("26f23bec-2855-4675-8fb9-eb20a2619b62"), 2, "Sancho Panza Metálico.", null, "Figura de Fierro de Don Quijote", 23250f },
                    { new Guid("31f3550b-7c05-46d9-9d87-9143e334b81c"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f },
                    { new Guid("68367bc2-3386-444e-b536-113991ceaf62"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("87cd4682-f5fa-4843-bc3e-4f758ca378ed"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f },
                    { new Guid("9bfffc66-e36d-4c2a-8b4b-782095d57ebd"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("c467ff12-6fbd-484e-b607-06686695aaea"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", null, "Aceite en Polvo", 6500f },
                    { new Guid("d99d7cc2-a736-41d0-ac13-145e3933bdda"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("07142810-eb41-4892-9e92-1bcf5f6c3c19"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("1c2fda0e-cff5-43fb-a26a-ee67ceb38a73"), "testerina@gmail.com", "Testerina", "admin", "Tester" },
                    { new Guid("e7c6ad17-f6ac-46c0-9927-0c0c3c5be309"), "acasas@gmail.com", "Armando", "admin", "Casas" }
                });
        }
    }
}
