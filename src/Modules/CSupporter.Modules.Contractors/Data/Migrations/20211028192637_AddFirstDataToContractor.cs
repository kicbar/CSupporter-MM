using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSupporter.Modules.Contractors.Migrations
{
    public partial class AddFirstDataToContractor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "Id", "Address", "CompanyDetails", "CompanyName", "FirstName", "InsertDate", "LastName", "NIP", "UpdateDate" },
                values: new object[] { new Guid("b1bb5d92-f31e-4f32-a55d-6316ed65e783"), "Warszawa, ul. Przedszkolna 15", "--", "GM Prime RN", "Richard", new DateTime(2021, 10, 28, 21, 26, 36, 786, DateTimeKind.Local).AddTicks(5877), "Nowak", "912-111-09-10", new DateTime(2021, 10, 28, 21, 26, 36, 786, DateTimeKind.Local).AddTicks(6003) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: new Guid("b1bb5d92-f31e-4f32-a55d-6316ed65e783"));
        }
    }
}
