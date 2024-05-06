using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ferramas.Migrations
{
    /// <inheritdoc />
    public partial class subscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09e88bcc-f02d-4ca7-81e0-9eaa0a02ce5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c7e6a1a-3086-4ece-b69e-3f71586f6b21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a21388c-9101-464e-8a64-a097c97911be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61981998-495f-4fc6-8220-ab40a9d9df17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c99fcbb9-4d7d-4871-8637-ccf188b6f6a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8a6381b-79bf-4f79-8e93-eef375c84bc6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecfb1b24-5c71-4143-92a7-f8bd09514866"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2032f322-70d2-4532-9219-f598158b7b68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27fadd5d-b1a7-49e8-aa26-24be2de4306d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dcedf4a-3e48-4626-ad61-31056c6ab39d"));

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_Email",
                table: "Subscriptions",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("09e88bcc-f02d-4ca7-81e0-9eaa0a02ce5c"), 6, "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", null, "Miembro a Escala", 7360f },
                    { new Guid("0c7e6a1a-3086-4ece-b69e-3f71586f6b21"), 4, "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", null, "Multiantena de Fierro", 6350f },
                    { new Guid("3a21388c-9101-464e-8a64-a097c97911be"), 3, "Para disfrazarte de alguien que se cree impuro.", null, "Látigo con Puntas Sin Filo", 10250f },
                    { new Guid("61981998-495f-4fc6-8220-ab40a9d9df17"), 5, "Para mostrar la fuerza que no tienes.", null, "Martillo Doble Golpe", 7360f },
                    { new Guid("c99fcbb9-4d7d-4871-8637-ccf188b6f6a8"), 2, "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", null, "Látigo con Puntas de Cobre", 13250f },
                    { new Guid("e8a6381b-79bf-4f79-8e93-eef375c84bc6"), 2, "Sancho Panza Metálico.", null, "Figura de Fierro de Don Quijote", 23250f },
                    { new Guid("ecfb1b24-5c71-4143-92a7-f8bd09514866"), 1, "Para hacerte el hipster y decir que cocinas todo con agua.", null, "Aceite en Polvo", 6500f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Surname" },
                values: new object[,]
                {
                    { new Guid("2032f322-70d2-4532-9219-f598158b7b68"), "testerina@gmail.com", "Testerina", "admin", "Tester" },
                    { new Guid("27fadd5d-b1a7-49e8-aa26-24be2de4306d"), "pe.palo@gmail.com", "Pedro", "admin", "Palote" },
                    { new Guid("9dcedf4a-3e48-4626-ad61-31056c6ab39d"), "acasas@gmail.com", "Armando", "admin", "Casas" }
                });
        }
    }
}
