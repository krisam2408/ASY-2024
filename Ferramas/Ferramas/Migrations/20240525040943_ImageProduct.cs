using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class ImageProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0a765b9f-6190-4d96-b0bd-c5fe81530788"), 1, "Para decir que cocinas todo con agua.", null, "Aceite en Polvo", 4670f },
                    { new Guid("1c83c2e0-d9f3-4d5f-8305-a377a5a2a800"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", "aceite.jpg", "Aceite en Polvo", 6500f },
                    { new Guid("26f2ff42-ee0a-422d-8986-914ce64f28ee"), 2, "Sancho Panza Metálico.", null, "Figura de Fierro de Don Quijote", 23250f },
                    { new Guid("47978fb0-cbb8-4d55-88c8-ac26298080af"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f },
                    { new Guid("4c83d1d2-07a6-4855-a1a2-ee34d86f912b"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("7a5813c2-26b1-4566-bbc8-6b2e7d78777c"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f },
                    { new Guid("870c1d2f-a711-4eba-b88e-7468f16229d5"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("a95a4b39-5465-47f9-93f3-ca80c40ab030"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("408d7435-f350-4e83-9add-3219c67b2127"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("6b889e61-b79b-4aa8-9ca0-e5424a9d0156"), "testerina@gmail.com", "Testerina", "admin", "Tester" },
                    { new Guid("7adb8f3a-4ab4-46e4-bd53-8029ba83a984"), "acasas@gmail.com", "Armando", "admin", "Casas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a765b9f-6190-4d96-b0bd-c5fe81530788"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c83c2e0-d9f3-4d5f-8305-a377a5a2a800"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26f2ff42-ee0a-422d-8986-914ce64f28ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47978fb0-cbb8-4d55-88c8-ac26298080af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c83d1d2-07a6-4855-a1a2-ee34d86f912b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a5813c2-26b1-4566-bbc8-6b2e7d78777c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("870c1d2f-a711-4eba-b88e-7468f16229d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a95a4b39-5465-47f9-93f3-ca80c40ab030"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("408d7435-f350-4e83-9add-3219c67b2127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b889e61-b79b-4aa8-9ca0-e5424a9d0156"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7adb8f3a-4ab4-46e4-bd53-8029ba83a984"));

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
    }
}
