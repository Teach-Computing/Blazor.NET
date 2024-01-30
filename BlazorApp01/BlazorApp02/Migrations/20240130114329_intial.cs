using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp02.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    RegistrationNo = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Phone", "RegistrationNo" },
                values: new object[,]
                {
                    { new Guid("2162a334-6c40-4e4d-a0ba-9512959f1775"), "Kenna26@hotmail.com", "Kenna", "Lindgren", "448-899-1270 x23119", "EG/2040/03562" },
                    { new Guid("2718e11a-a30e-40d3-9c5e-d19991faede2"), "Ottis.Gutmann@yahoo.com", "Ottis", "Gutmann", "1-856-988-6512 x15183", "EG/2020/01224" },
                    { new Guid("278d77d9-ac29-4b1e-8e95-1f375b7086ed"), "Bret14@hotmail.com", "Bret", "Franecki", "909.701.5955", "EG/2031/04851" },
                    { new Guid("4630c8d0-3ce9-4f72-a4bf-5aa8002de602"), "Darrell48@hotmail.com", "Darrell", "Bruen", "599.533.5637", "EG/2040/04154" },
                    { new Guid("46c42434-d9a1-4924-8f3b-95fc04ae276d"), "Hyman.Moore@gmail.com", "Hyman", "Moore", "(832) 278-5314 x081", "EG/2048/06248" },
                    { new Guid("739d051d-18b9-45b8-b9d4-cd93589133a3"), "Lucie46@yahoo.com", "Lucie", "Hahn", "1-737-411-0185 x85705", "EG/2025/02400" },
                    { new Guid("84332f21-fd87-491b-860b-92ec517eb40c"), "Andy89@hotmail.com", "Andy", "Ullrich", "576-849-2134 x477", "EG/2046/06161" },
                    { new Guid("97e660ac-1d40-41ef-ba81-87505d8aab0e"), "Myrtis.Boyle@gmail.com", "Myrtis", "Boyle", "951.949.9045", "EG/2033/06269" },
                    { new Guid("98bd57c5-6cc9-469d-88bf-bafcabe02e9c"), "Tony.Schuster34@gmail.com", "Tony", "Schuster", "852.261.5868 x63261", "EG/2043/03142" },
                    { new Guid("d479fd97-faa8-4a72-93b1-e5b5c0d06e43"), "Ida23@yahoo.com", "Ida", "Cummings", "663-363-5768 x47281", "EG/2035/03921" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
