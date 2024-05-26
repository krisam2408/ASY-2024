using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class Image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("08c88d7e-cc84-4576-aa9c-9ca6d67e42d3"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", "cuerda1.webp", "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("0e7d6608-11eb-4cc2-a152-7b891c35dbad"), 3, "Para disfrazarte de alguien que se cree impuro.", "cuerda2.jpg", "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("157e1c6d-28eb-4443-8952-494efc1c7de6"), 4, "Un televisor invisible,no hay mas descripcion", "nada.jpg", "Television invisible", 256000f },
                    { new Guid("3752fecc-6b73-49ab-ad82-7eb05993ef4f"), 2, "Para hacer el pan de los dioses", "Tostador.jpg", "Tostador chileno", 5000f },
                    { new Guid("3dc60a68-297b-4ae9-9248-636fbf03b09d"), 3, "Creeme es una buena compra", "Diccionario.jpg", "Diccionario para entender a las mujeres", 7500f },
                    { new Guid("4539008b-1cc4-4181-b056-49135666d1c7"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", "p.webp", "Miembro a Escala", 7360f },
                    { new Guid("525ed98e-e899-4453-9b7d-577117439782"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", "aceite.jpg", "Aceite en Polvo", 6500f },
                    { new Guid("52bf07fa-2652-4242-bd10-da6f0983806a"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", "Antena.jpg", "Multiantena de Fierro", 6350f },
                    { new Guid("56ff595b-0696-45da-ac12-ed2542e4b9b9"), 5, "Para mostrar la fuerza que no tienes.", "martillo.jpg", "Martillo Doble Golpe", 7360f },
                    { new Guid("65c0c4e3-7163-4cad-aa44-07f0919e8c81"), 5, "Ideal para construir aeroplanos", "inalambrico.jpg", "Cable inalambrico", 6000f },
                    { new Guid("89d06704-9615-4a54-8bfe-2b257fbd84ed"), 2, "La ventana ideal", "Hielo7.gif", "Ventana de hielo 7", 1000f },
                    { new Guid("ab9697c1-8a7c-4c4b-baa6-5e425b9f2ada"), 1, "Para evitar la sal", "sal.webp", "Sal sin sodio", 1200f },
                    { new Guid("b1f4ceba-f7db-40d9-bd84-63cf70a59419"), 3, "La pelota de quico finalmente ha llegado al mercado", "Pelota.jpg", "Pelota cuadrada", 2000f },
                    { new Guid("c166f54c-a783-4e46-9d5b-fee493c7d559"), 5, "En el pais no existe", "cadenai.jpg", "Cadena perpetua", 9000f },
                    { new Guid("c349bc28-a82c-4998-b05c-d778bdd84fc1"), 6, "Regalalo", "cosplay.webp", "Cosplay de enfermera", 4990f },
                    { new Guid("d9e7a88a-7a01-4849-839b-21e9985034d6"), 1, "Nose porque diablos alguien compraria esto", "mayo.jpg", "NOT MAYO", 3500f },
                    { new Guid("dc0d497c-3955-471f-a720-ff448f712d5a"), 4, "Finge estatus pero con algo de cerebro", "Iphone.webp", "Iphone con bateria incluida", 1000000f },
                    { new Guid("fc5e4d21-8857-4b51-8ee6-cc1ff8271c59"), 6, "Ropa de mal gusto", "ropa.jpg", "Ropa de mal gusto", 10f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("093ff76f-0c1f-4c4d-a822-f6abd50b8f17"), "testerina@gmail.com", "Testerina", "admin", "Tester" },
                    { new Guid("10999660-2573-4337-b23c-62a96d001818"), "acasas@gmail.com", "Armando", "admin", "Casas" },
                    { new Guid("2dda50a6-147f-443b-8c00-d35dc385ca8e"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08c88d7e-cc84-4576-aa9c-9ca6d67e42d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e7d6608-11eb-4cc2-a152-7b891c35dbad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("157e1c6d-28eb-4443-8952-494efc1c7de6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3752fecc-6b73-49ab-ad82-7eb05993ef4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dc60a68-297b-4ae9-9248-636fbf03b09d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4539008b-1cc4-4181-b056-49135666d1c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("525ed98e-e899-4453-9b7d-577117439782"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52bf07fa-2652-4242-bd10-da6f0983806a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56ff595b-0696-45da-ac12-ed2542e4b9b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65c0c4e3-7163-4cad-aa44-07f0919e8c81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89d06704-9615-4a54-8bfe-2b257fbd84ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab9697c1-8a7c-4c4b-baa6-5e425b9f2ada"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1f4ceba-f7db-40d9-bd84-63cf70a59419"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c166f54c-a783-4e46-9d5b-fee493c7d559"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c349bc28-a82c-4998-b05c-d778bdd84fc1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9e7a88a-7a01-4849-839b-21e9985034d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc0d497c-3955-471f-a720-ff448f712d5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc5e4d21-8857-4b51-8ee6-cc1ff8271c59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("093ff76f-0c1f-4c4d-a822-f6abd50b8f17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10999660-2573-4337-b23c-62a96d001818"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dda50a6-147f-443b-8c00-d35dc385ca8e"));

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
    }
}
