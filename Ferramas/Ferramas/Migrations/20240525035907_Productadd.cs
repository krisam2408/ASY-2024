using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class Productadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3c14f8fe-ee7d-4e81-8d79-088ed52fbc6f"), 2, "Sancho Panza Metálico.", null, "Figura de Fierro de Don Quijote", 23250f },
                    { new Guid("42ade1c9-ab2a-4fe9-8cee-1df68812500b"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f },
                    { new Guid("44362ae9-9af8-47d4-bccd-a14ee0d74068"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("794d0819-516d-4400-b12e-03e9cd190f4a"), 1, "Para decir que cocinas todo con agua.", null, "Aceite en Polvo", 4670f },
                    { new Guid("a61be19e-bbc8-4fef-a534-b54006e32177"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f },
                    { new Guid("b44fd4b9-b6f7-4dad-8033-e1047b8006bb"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f },
                    { new Guid("dc440f68-1887-49f6-9e7c-c202cc0ff293"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("f1cbff24-8db4-45f7-a723-eacde467504c"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", null, "Aceite en Polvo", 6500f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("157ca52d-268f-40fc-9d39-046a806ae737"), "acasas@gmail.com", "Armando", "admin", "Casas" },
                    { new Guid("7aa4c99d-3d85-4666-a224-e426416f1223"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("8afa4fa5-37a1-481d-b4a8-c1187b588a57"), "testerina@gmail.com", "Testerina", "admin", "Tester" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c14f8fe-ee7d-4e81-8d79-088ed52fbc6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42ade1c9-ab2a-4fe9-8cee-1df68812500b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44362ae9-9af8-47d4-bccd-a14ee0d74068"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("794d0819-516d-4400-b12e-03e9cd190f4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a61be19e-bbc8-4fef-a534-b54006e32177"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b44fd4b9-b6f7-4dad-8033-e1047b8006bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc440f68-1887-49f6-9e7c-c202cc0ff293"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1cbff24-8db4-45f7-a723-eacde467504c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("157ca52d-268f-40fc-9d39-046a806ae737"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7aa4c99d-3d85-4666-a224-e426416f1223"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8afa4fa5-37a1-481d-b4a8-c1187b588a57"));

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
    }
}
