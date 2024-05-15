using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class TransabankSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "TransbankSession",
                table: "Purchases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("09de98f4-03ba-4f16-be9f-6cf231d666ec"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("1166f530-4917-4a5e-a832-b643a81539b4"), 2, "Sancho Panza Metálico.", null, "Figura de Fierro de Don Quijote", 23250f },
                    { new Guid("2395eda7-3a35-4721-81e2-43ebbd48c0c1"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f },
                    { new Guid("45cf756c-bb0e-40ac-b2e5-2b3b06c6b503"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", null, "Aceite en Polvo", 6500f },
                    { new Guid("55c58833-27e1-453f-aae2-5e419bf7e691"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f },
                    { new Guid("5f3533c9-b1a9-4501-bdac-70b7095ee267"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("a1526dc2-ad6c-4d6f-930b-378d9372f69f"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("9663b650-16ca-4119-a371-e28c57df3ed5"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("9875d2bc-19c0-49f3-a7fb-08219555f574"), "testerina@gmail.com", "Testerina", "admin", "Tester" },
                    { new Guid("ff4f2df3-7a06-4e8c-a513-819733905b03"), "acasas@gmail.com", "Armando", "admin", "Casas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09de98f4-03ba-4f16-be9f-6cf231d666ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1166f530-4917-4a5e-a832-b643a81539b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2395eda7-3a35-4721-81e2-43ebbd48c0c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45cf756c-bb0e-40ac-b2e5-2b3b06c6b503"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55c58833-27e1-453f-aae2-5e419bf7e691"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f3533c9-b1a9-4501-bdac-70b7095ee267"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1526dc2-ad6c-4d6f-930b-378d9372f69f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9663b650-16ca-4119-a371-e28c57df3ed5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9875d2bc-19c0-49f3-a7fb-08219555f574"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff4f2df3-7a06-4e8c-a513-819733905b03"));

            migrationBuilder.DropColumn(
                name: "TransbankSession",
                table: "Purchases");

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
    }
}
