using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class Productss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("3825b94a-0c39-44a4-80da-0aec043148ca"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f },
                    { new Guid("3d66baca-25d8-4fcf-8636-48c89b0fdbdb"), 4, "Un televisor invisible,no hay mas descripcion", null, "Television invisible", 256000f },
                    { new Guid("43205b8c-c233-484a-b583-a0db07c1abdb"), 1, "Para evitar la sal", null, "Sal sin sodio", 1200f },
                    { new Guid("4764efa6-4206-44ac-838d-a78525ddd3ab"), 3, "Creeme es una buena compra", null, "Diccionario para entender a las mujeres", 7500f },
                    { new Guid("5461ae64-623b-42bd-a9fc-afc33f168f1f"), 2, "La ventana ideal", null, "Ventana de hielo 7", 1000f },
                    { new Guid("594c0f1e-81d0-44b6-b39e-c33b98e661ea"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f },
                    { new Guid("5a614efe-01a8-4825-afc4-2d5511265e82"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("619aa464-0f71-42e0-9bbb-426e6720ab98"), 6, "Ropa de mal gusto", null, "Ropa de mal gusto", 10f },
                    { new Guid("65c88822-858f-4594-be91-672bf09ecf52"), 5, "En el pais no existe", null, "Cadena perpetua", 9000f },
                    { new Guid("69034056-9fd5-4407-8f4f-f8d93a1163f1"), 1, "Nose porque diablos alguien compraria esto", null, "NOT MAYO", 3500f },
                    { new Guid("72b14fe5-5bae-44f3-8814-8bcac0b008a9"), 5, "Ideal para construir aeroplanos", null, "Cable inalambrico", 6000f },
                    { new Guid("858bb151-a1e6-4a5c-9aa6-d66d72e59a6a"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("914ac68a-ccd8-4526-8823-c0d68ddb2ef8"), 4, "Finge estatus pero con algo de cerebro", null, "Iphone con bateria incluida", 1000000f },
                    { new Guid("990a6c62-bde9-460e-9984-a3e7c26d3f96"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", "aceite.jpg", "Aceite en Polvo", 6500f },
                    { new Guid("a996a696-a27d-4962-92df-dbae7dce8011"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f },
                    { new Guid("aee40fa5-74ff-478c-b644-06dc9d2c8eca"), 2, "Para hacer el pan de los dioses", null, "Tostador chileno", 5000f },
                    { new Guid("c8e418d7-7930-44c5-a1ba-da65de410674"), 6, "Regalalo", null, "Cosplay de enfermera", 4990f },
                    { new Guid("d2ee9f6c-26c4-4fb3-b120-2fc6671e41cb"), 3, "La pelota de quico finalmente ha llgeaod al mercado", null, "Pelota cuadrada", 2000f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("cb8c5393-ca1e-4f02-bf9e-a5228800e723"), "testerina@gmail.com", "Testerina", "admin", "Tester" },
                    { new Guid("d28bd27c-46f6-45ab-9584-e26d328c1fca"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("f999fdf7-3060-433c-bb55-a1647d3ea990"), "acasas@gmail.com", "Armando", "admin", "Casas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3825b94a-0c39-44a4-80da-0aec043148ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d66baca-25d8-4fcf-8636-48c89b0fdbdb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43205b8c-c233-484a-b583-a0db07c1abdb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4764efa6-4206-44ac-838d-a78525ddd3ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5461ae64-623b-42bd-a9fc-afc33f168f1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("594c0f1e-81d0-44b6-b39e-c33b98e661ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a614efe-01a8-4825-afc4-2d5511265e82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("619aa464-0f71-42e0-9bbb-426e6720ab98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65c88822-858f-4594-be91-672bf09ecf52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69034056-9fd5-4407-8f4f-f8d93a1163f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72b14fe5-5bae-44f3-8814-8bcac0b008a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("858bb151-a1e6-4a5c-9aa6-d66d72e59a6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("914ac68a-ccd8-4526-8823-c0d68ddb2ef8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("990a6c62-bde9-460e-9984-a3e7c26d3f96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a996a696-a27d-4962-92df-dbae7dce8011"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aee40fa5-74ff-478c-b644-06dc9d2c8eca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8e418d7-7930-44c5-a1ba-da65de410674"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2ee9f6c-26c4-4fb3-b120-2fc6671e41cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb8c5393-ca1e-4f02-bf9e-a5228800e723"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d28bd27c-46f6-45ab-9584-e26d328c1fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f999fdf7-3060-433c-bb55-a1647d3ea990"));

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
    }
}
