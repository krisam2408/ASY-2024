using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("03032799-7e89-4e75-8132-8e43290a78ee"), 3, "Creeme es una buena compra", null, "Diccionario para entender a las mujeres", 7500f },
                    { new Guid("031cd7bc-8529-45ac-8def-e9592bb60a90"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f },
                    { new Guid("202a427d-e9ac-4f52-8d10-6ef7e50b2d84"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f },
                    { new Guid("445a8581-bcb3-4cdb-82b3-3292fd664ab8"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", "aceite.jpg", "Aceite en Polvo", 6500f },
                    { new Guid("469c44ee-900d-4cd5-8ddb-8419bf66e999"), 1, "Para evitar la sal", null, "Sal sin sodio", 1200f },
                    { new Guid("62a6aa90-e1f6-439a-b5a1-129220ecb2a2"), 6, "Regalalo", null, "Cosplay de enfermera", 4990f },
                    { new Guid("837e8b95-bcf4-4b88-b38b-665d2fc4aac1"), 4, "Un televisor invisible,no hay mas descripcion", null, "Television invisible", 256000f },
                    { new Guid("8a33c4f5-0f4d-4458-82f7-12616bc8ddf7"), 5, "En el pais no existe", null, "Cadena perpetua", 9000f },
                    { new Guid("91214ed9-978a-4632-98b4-c45352767705"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("a1183b3b-73ee-4a89-a35b-dcffcab9ff9d"), 1, "Nose porque diablos alguien compraria esto", null, "NOT MAYO", 3500f },
                    { new Guid("a6cadb5f-e6e3-4bc0-8b4b-99e57d035301"), 2, "Para hacer el pan de los dioses", null, "Tostador chileno", 5000f },
                    { new Guid("aac94e45-bdc6-42f7-b50e-3f468a0b86be"), 3, "La pelota de quico finalmente ha llgeaod al mercado", null, "Pelota cuadrada", 2000f },
                    { new Guid("baed9fe6-e4fb-4c00-8db4-0946ba563b02"), 6, "Ropa de mal gusto", null, "Ropa de mal gusto", 10f },
                    { new Guid("eb741d84-a5a1-4097-99a2-3e2783dd23a6"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f },
                    { new Guid("ef049cf7-e0ac-4e9f-a98f-f87c8bcba73b"), 2, "La ventana ideal", null, "Ventana de hielo 7", 1000f },
                    { new Guid("f324033d-6d9f-4eaf-b2af-728733f14c75"), 4, "Finge estatus pero con algo de cerebro", null, "Iphone con bateria incluida", 1000000f },
                    { new Guid("faf2e6e9-b2b5-4032-b88e-834c4e96c58b"), 5, "Ideal para construir aeroplanos", null, "Cable inalambrico", 6000f },
                    { new Guid("fe4d41ae-a0b1-4f8a-ad4a-33bf6c698a74"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("243bb0d2-1c86-4df1-98c7-d1cf925db0c3"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("588ea360-eaec-4e08-97da-2d9bc17cebad"), "acasas@gmail.com", "Armando", "admin", "Casas" },
                    { new Guid("7bfa761f-14ad-408a-b404-9ba7d492605f"), "testerina@gmail.com", "Testerina", "admin", "Tester" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03032799-7e89-4e75-8132-8e43290a78ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("031cd7bc-8529-45ac-8def-e9592bb60a90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("202a427d-e9ac-4f52-8d10-6ef7e50b2d84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("445a8581-bcb3-4cdb-82b3-3292fd664ab8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("469c44ee-900d-4cd5-8ddb-8419bf66e999"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62a6aa90-e1f6-439a-b5a1-129220ecb2a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("837e8b95-bcf4-4b88-b38b-665d2fc4aac1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a33c4f5-0f4d-4458-82f7-12616bc8ddf7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91214ed9-978a-4632-98b4-c45352767705"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1183b3b-73ee-4a89-a35b-dcffcab9ff9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6cadb5f-e6e3-4bc0-8b4b-99e57d035301"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aac94e45-bdc6-42f7-b50e-3f468a0b86be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baed9fe6-e4fb-4c00-8db4-0946ba563b02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb741d84-a5a1-4097-99a2-3e2783dd23a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef049cf7-e0ac-4e9f-a98f-f87c8bcba73b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f324033d-6d9f-4eaf-b2af-728733f14c75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("faf2e6e9-b2b5-4032-b88e-834c4e96c58b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe4d41ae-a0b1-4f8a-ad4a-33bf6c698a74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("243bb0d2-1c86-4df1-98c7-d1cf925db0c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("588ea360-eaec-4e08-97da-2d9bc17cebad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bfa761f-14ad-408a-b404-9ba7d492605f"));

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
    }
}
