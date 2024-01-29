using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp01.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
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
                    { new Guid("2bb15c87-f5b6-4eab-9ff2-05b97c6e1d74"), "Raegan.Kris21@gmail.com", "Raegan", "Kris", "(975) 850-9453", "EG/2023/08943" },
                    { new Guid("36897ecf-e6ef-4e0f-86ad-a4ffc8e8d951"), "Braulio_Jones93@hotmail.com", "Braulio", "Jones", "810.425.6898 x54144", "EG/2034/08075" },
                    { new Guid("42270363-162b-4ff2-a537-e04f6be49b88"), "Kassandra20@hotmail.com", "Kassandra", "Grimes", "848.323.2533 x369", "EG/2038/09829" },
                    { new Guid("692c6e43-fc9b-4282-9cc4-014caf8ab68d"), "Mitchel_Borer@yahoo.com", "Mitchel", "Borer", "(895) 249-1947 x32181", "EG/2025/06947" },
                    { new Guid("77aa0f0d-6eef-4a52-aee4-a0277acb60a0"), "Dallin.Grant55@yahoo.com", "Dallin", "Grant", "(666) 407-2654 x84596", "EG/2030/04799" },
                    { new Guid("8129eeb7-029a-4ef7-96fb-b1c45608f767"), "Margarita_Lindgren44@gmail.com", "Margarita", "Lindgren", "476-779-4370 x08371", "EG/2045/06243" },
                    { new Guid("8ed8bd5a-4618-4b58-99dc-535e4db02855"), "Westley_Reilly@yahoo.com", "Westley", "Reilly", "(319) 978-0686", "EG/2022/04656" },
                    { new Guid("931f1eb8-5892-4cd6-9b2f-4cce771c0c49"), "Mathilde9@gmail.com", "Mathilde", "Ledner", "1-344-239-3110 x53703", "EG/2042/09702" },
                    { new Guid("9cba46e9-9d1b-4633-b5e2-7279baff1473"), "Buford91@gmail.com", "Buford", "Walsh", "529-971-3567", "EG/2023/08762" },
                    { new Guid("9f21b39a-e4f6-4004-80bf-827cc633ffee"), "Wallace_Hudson87@hotmail.com", "Wallace", "Hudson", "1-606-676-6585", "EG/2033/03529" }
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
