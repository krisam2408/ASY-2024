using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class ImageRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0835f86c-8453-47fb-849e-3da6773ba511"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10e75d11-aeab-45c2-abc5-38d173b474fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("261fbdec-bb84-4cd7-a25e-748f6974d892"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57b59b36-1b72-43a2-a060-9ad1e36bdb2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a70b694-bc25-4c55-9d1f-f5d4ee217dda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72455ff7-f40d-4752-9d42-bb25bbc39c24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2c8ddcf-aed7-4b48-82d3-287a6252d281"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57b15f6f-12f0-4912-a8bf-96bead3ae091"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8fc0f0aa-e5ea-4fa9-a82b-c282cedb433e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3486276-80a6-461d-9874-43566c0631fe"));

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "Image");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "ImageUrl");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0835f86c-8453-47fb-849e-3da6773ba511"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", null, "Aceite en Polvo", 6500f },
                    { new Guid("10e75d11-aeab-45c2-abc5-38d173b474fb"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f },
                    { new Guid("261fbdec-bb84-4cd7-a25e-748f6974d892"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f },
                    { new Guid("57b59b36-1b72-43a2-a060-9ad1e36bdb2b"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("6a70b694-bc25-4c55-9d1f-f5d4ee217dda"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f },
                    { new Guid("72455ff7-f40d-4752-9d42-bb25bbc39c24"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("e2c8ddcf-aed7-4b48-82d3-287a6252d281"), 2, "Sancho Panza Metálico.", null, "Figura de Fierro de Don Quijote", 23250f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("57b15f6f-12f0-4912-a8bf-96bead3ae091"), "acasas@gmail.com", "Armando", "admin", "Casas" },
                    { new Guid("8fc0f0aa-e5ea-4fa9-a82b-c282cedb433e"), "testerina@gmail.com", "Testerina", "admin", "Tester" },
                    { new Guid("c3486276-80a6-461d-9874-43566c0631fe"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" }
                });
        }
    }
}
