using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("05671a19-9cbb-46f4-b9cc-c1813f34bedf"), 2, "Una ventana que te permitira ver el otro mundo", "Hielo7.gif", "Ventana de hielo 7", 1000f },
                    { new Guid("05683091-8eba-4e0e-b10f-68e1d670e96d"), 5, "En el pais no existe", "cadenai.jpg", "Cadena perpetua", 9000f },
                    { new Guid("12c3623d-1c5b-4bbb-9509-eeded088fb01"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", "cuerda1.webp", "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("242d54bd-18a5-4510-afba-9d8ac3309fff"), 4, "Finge estatus pero con algo de cerebro", "Iphone.webp", "Iphone con bateria incluida", 1000000f },
                    { new Guid("48d92b3d-8d68-4fd5-9800-ec25ba8ebd0c"), 5, "Para mostrar la fuerza que no tienes.", "martillo.jpg", "Martillo Doble Golpe", 7360f },
                    { new Guid("5e734697-2fd4-4d9a-8f14-dc585e72840c"), 3, "Si te sientes inutil, entonces no haz conocido este manual", "Diccionario.jpg", "Hagalo usted mismo manual", 7500f },
                    { new Guid("75a728da-38aa-49cb-b22f-c8313c522c63"), 6, "La mejor ropa blindada para visitar puente alto", "ropa.jpg", "Blindaje anti portonazo", 10f },
                    { new Guid("86d80819-054d-4f20-a71e-8939d073a4f3"), 3, "Para disfrazarte de alguien que se cree impuro.", "cuerda2.jpg", "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("9aa1a959-cfe7-4625-b837-bdc5dacba9b8"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", "aceite.jpg", "Aceite en Polvo", 6500f },
                    { new Guid("a283065b-e854-49ad-b5ab-33d747fd0f87"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", "p.webp", "Miembro a Escala", 7360f },
                    { new Guid("aedc4959-4dfc-4048-b573-9cc43ac68438"), 1, "Un buen producto para nuestros amantes de la cocina, solo no te vayas a equivocar de salero", "sal.webp", "Soda caustica en formato salero", 1200f },
                    { new Guid("bd94180a-eeb2-4771-90f7-fff86f367bed"), 2, "Para hacer el pan de los dioses", "Tostador.jpg", "Tostador chileno", 5000f },
                    { new Guid("c4d40032-f26f-4a0c-9874-60277f42e66d"), 1, "Mayo vegana con hierro extra para nuestros anemicos favoritos", "mayo.jpg", "NOT MAYO", 3500f },
                    { new Guid("e4de66fb-c174-42fd-bc47-c426b0dc8e5e"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", "Antena.jpg", "Multiantena de Fierro", 6350f },
                    { new Guid("e7be64e3-6204-4c02-b39e-2d726e3f57ef"), 4, "Un televisor invisible,no hay mas descripcion", "nada.jpg", "Television invisible", 256000f },
                    { new Guid("eef02b72-ce0f-45ab-bda6-721718d44de9"), 3, "Pateala y el hospital te esperara", "Pelota.jpg", "Pelota cuadrada de acero reforzado", 2000f },
                    { new Guid("f11395ac-b712-432d-abea-c2eef329deda"), 5, "Ideal para construir aeroplanos", "inalambrico.jpg", "Cable inalambrico", 6000f },
                    { new Guid("fe97ff22-9a0d-41c6-bca2-2eca9cefd36c"), 6, "Prenda que trae sorpresa", "cosplay.webp", "Cosplay de enfermera", 4990f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("0be7c2dc-5f4b-4175-a2be-940b1edda83b"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("1b1ff9cf-8f46-4d0b-8c93-4c2f5f97ea0c"), "acasas@gmail.com", "Armando", "admin", "Casas" },
                    { new Guid("44a1e669-a3a6-4437-a2cc-6eddbfd1b01c"), "testerina@gmail.com", "Testerina", "admin", "Tester" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05671a19-9cbb-46f4-b9cc-c1813f34bedf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05683091-8eba-4e0e-b10f-68e1d670e96d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12c3623d-1c5b-4bbb-9509-eeded088fb01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("242d54bd-18a5-4510-afba-9d8ac3309fff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48d92b3d-8d68-4fd5-9800-ec25ba8ebd0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e734697-2fd4-4d9a-8f14-dc585e72840c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75a728da-38aa-49cb-b22f-c8313c522c63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86d80819-054d-4f20-a71e-8939d073a4f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9aa1a959-cfe7-4625-b837-bdc5dacba9b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a283065b-e854-49ad-b5ab-33d747fd0f87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aedc4959-4dfc-4048-b573-9cc43ac68438"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd94180a-eeb2-4771-90f7-fff86f367bed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4d40032-f26f-4a0c-9874-60277f42e66d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4de66fb-c174-42fd-bc47-c426b0dc8e5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7be64e3-6204-4c02-b39e-2d726e3f57ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eef02b72-ce0f-45ab-bda6-721718d44de9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f11395ac-b712-432d-abea-c2eef329deda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe97ff22-9a0d-41c6-bca2-2eca9cefd36c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0be7c2dc-5f4b-4175-a2be-940b1edda83b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b1ff9cf-8f46-4d0b-8c93-4c2f5f97ea0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44a1e669-a3a6-4437-a2cc-6eddbfd1b01c"));

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
    }
}
