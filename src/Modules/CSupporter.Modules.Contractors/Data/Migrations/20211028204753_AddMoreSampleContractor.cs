using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSupporter.Modules.Contractors.Migrations
{
    public partial class AddMoreSampleContractor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: new Guid("b1bb5d92-f31e-4f32-a55d-6316ed65e783"));

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "Id", "Address", "CompanyDetails", "CompanyName", "FirstName", "InsertDate", "LastName", "NIP", "UpdateDate" },
                values: new object[] { new Guid("955fb204-a56d-43c6-8117-31fe22537483"), "Warszawa, ul. Przedszkolna 15", "--", "GM Prime RN", "Richard", new DateTime(2021, 10, 28, 22, 47, 53, 31, DateTimeKind.Local).AddTicks(5685), "Nowak", "912-111-09-10", new DateTime(2021, 10, 28, 22, 47, 53, 31, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "Id", "Address", "CompanyDetails", "CompanyName", "FirstName", "InsertDate", "LastName", "NIP", "UpdateDate" },
                values: new object[] { new Guid("f6738f1f-5d8a-442c-8386-98668e83493d"), "Gdański, ul. Mariacka 8", "--", "FUH Adrian", "Adrian", new DateTime(2021, 10, 28, 22, 47, 53, 35, DateTimeKind.Local).AddTicks(1793), "Kowalski", "805-111-09-10", new DateTime(2021, 10, 28, 22, 47, 53, 35, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "Id", "Address", "CompanyDetails", "CompanyName", "FirstName", "InsertDate", "LastName", "NIP", "UpdateDate" },
                values: new object[] { new Guid("f485167a-ff16-4a8c-83d5-1379a86ca8ff"), "Wrocław, ul. Żeromskiego 10", "--", "KOMFORT", "Roman", new DateTime(2021, 10, 28, 22, 47, 53, 35, DateTimeKind.Local).AddTicks(2134), "Romanowicz", "712-934-35-23", new DateTime(2021, 10, 28, 22, 47, 53, 35, DateTimeKind.Local).AddTicks(2150) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: new Guid("955fb204-a56d-43c6-8117-31fe22537483"));

            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: new Guid("f485167a-ff16-4a8c-83d5-1379a86ca8ff"));

            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: new Guid("f6738f1f-5d8a-442c-8386-98668e83493d"));

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "Id", "Address", "CompanyDetails", "CompanyName", "FirstName", "InsertDate", "LastName", "NIP", "UpdateDate" },
                values: new object[] { new Guid("b1bb5d92-f31e-4f32-a55d-6316ed65e783"), "Warszawa, ul. Przedszkolna 15", "--", "GM Prime RN", "Richard", new DateTime(2021, 10, 28, 21, 26, 36, 786, DateTimeKind.Local).AddTicks(5877), "Nowak", "912-111-09-10", new DateTime(2021, 10, 28, 21, 26, 36, 786, DateTimeKind.Local).AddTicks(6003) });
        }
    }
}
