using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MudBlazorWebApp1.Migrations
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
                    { new Guid("08f600cf-f767-4ae7-8063-fb5fc8e51979"), "Jacinto_DAmore@yahoo.com", "Jacinto", "D'Amore", "366.537.2044", "EG/2050/02968" },
                    { new Guid("0be9a42e-7e2f-4611-85ab-a00ba7da4b91"), "Mose_Powlowski@yahoo.com", "Mose", "Powlowski", "641.652.9868 x174", "EG/2026/06713" },
                    { new Guid("1b8a4646-69d3-44c4-8914-fba1e906c64c"), "Malcolm_Kessler@hotmail.com", "Malcolm", "Kessler", "(491) 579-8971 x05976", "EG/2042/03290" },
                    { new Guid("3dc8d548-2c50-4049-a8a1-c7f45e5488b0"), "Jerald_Rosenbaum99@gmail.com", "Jerald", "Rosenbaum", "(660) 889-0394", "EG/2037/05622" },
                    { new Guid("422350c1-82a3-4bae-80e1-e0eab10175de"), "Eriberto_Bosco@gmail.com", "Eriberto", "Bosco", "(639) 834-0332 x739", "EG/2024/06099" },
                    { new Guid("439f7f45-cc6d-48c7-822a-e20b8c5cacdd"), "Alvah89@hotmail.com", "Alvah", "Bins", "480.965.2228", "EG/2026/03032" },
                    { new Guid("446a0f73-be2e-488f-85b0-2e3bd4a17838"), "Perry.McClure25@yahoo.com", "Perry", "McClure", "624.951.2400", "EG/2030/07024" },
                    { new Guid("4e21b396-ed87-44c3-a154-00574799bf27"), "America_Hermiston@gmail.com", "America", "Hermiston", "559.505.6362", "EG/2028/01479" },
                    { new Guid("5722c181-0e52-4569-bec7-9ed15ed001a1"), "Rylee_Kilback@hotmail.com", "Rylee", "Kilback", "703-769-3203 x8610", "EG/2023/02290" },
                    { new Guid("5749f93a-ee1d-4426-9b13-03ea75c588f5"), "Ellsworth.Lockman79@hotmail.com", "Ellsworth", "Lockman", "774.403.5267", "EG/2046/01959" },
                    { new Guid("58719496-4bfa-4fb7-8bf7-345edecb1302"), "Ana.Jenkins4@hotmail.com", "Ana", "Jenkins", "(924) 553-9521", "EG/2029/04412" },
                    { new Guid("594cbfb7-308b-43fd-afc8-bda89868a3bc"), "Dayna58@yahoo.com", "Dayna", "Grimes", "890.838.5650 x1016", "EG/2038/07756" },
                    { new Guid("6ae24a9e-e14b-43d1-8a35-e4480cf20e79"), "Orrin_Morissette@yahoo.com", "Orrin", "Morissette", "1-557-672-0907", "EG/2044/05709" },
                    { new Guid("70d768a3-cd65-4b21-b180-512ebfb6258e"), "Lon15@gmail.com", "Lon", "Bruen", "216-669-2788 x337", "EG/2032/07393" },
                    { new Guid("726de089-3056-4bbb-9d43-9a5167e44559"), "Hillary_McClure@gmail.com", "Hillary", "McClure", "1-914-349-4180 x7917", "EG/2023/06059" },
                    { new Guid("72a3b15e-b804-41e8-aca1-5a46361a5724"), "Mara.Toy15@gmail.com", "Mara", "Toy", "974-391-5455 x10928", "EG/2041/01926" },
                    { new Guid("74758780-a38c-4cca-aa0b-7a2225f7ee95"), "Vita72@gmail.com", "Vita", "Heaney", "1-607-948-9580 x2456", "EG/2027/03024" },
                    { new Guid("79834c26-96d7-4fe8-af94-27029f76da39"), "Cody_Mohr23@yahoo.com", "Cody", "Mohr", "(934) 721-6089 x90964", "EG/2033/06289" },
                    { new Guid("7f83b2fc-1481-4db4-a8af-4a36d1299842"), "Jaida_Klocko13@yahoo.com", "Jaida", "Klocko", "573.356.2893 x299", "EG/2034/01573" },
                    { new Guid("8d90510a-38a0-4c7b-9b7c-88ce3a2ae915"), "Kristian49@hotmail.com", "Kristian", "Fadel", "889.797.8586", "EG/2050/09133" },
                    { new Guid("9d3645bf-b78c-4703-b8c0-a6844dcf1deb"), "Nona.Streich@gmail.com", "Nona", "Streich", "698-832-7384 x0188", "EG/2034/05338" },
                    { new Guid("a265bf77-3ff7-4a7c-ac87-b38ba6db3008"), "Serena_Hirthe@gmail.com", "Serena", "Hirthe", "441-331-3301", "EG/2025/02687" },
                    { new Guid("a5845fba-f35d-4942-9c5f-e4943d28ecec"), "Lynn.Witting@hotmail.com", "Lynn", "Witting", "1-994-432-9981 x3685", "EG/2042/01137" },
                    { new Guid("a9dd38a2-596a-4818-9ddc-126d0ac373e0"), "Karen99@hotmail.com", "Karen", "Turner", "(824) 677-2078 x5293", "EG/2043/01705" },
                    { new Guid("bd000c96-4cf2-4572-9fff-f7338010ef44"), "Daniella.Pollich@hotmail.com", "Daniella", "Pollich", "526-266-3300", "EG/2032/02776" },
                    { new Guid("d629ad15-621c-43ac-a4bb-68ef73de62bd"), "Bridgette2@yahoo.com", "Bridgette", "Douglas", "(541) 905-6598 x08424", "EG/2039/04464" },
                    { new Guid("e05c153c-4de7-4cb3-99f7-6f34bbafb5cf"), "Wava.Vandervort87@hotmail.com", "Wava", "Vandervort", "(228) 306-2123 x9207", "EG/2033/08281" },
                    { new Guid("e0daac4f-5c3e-484c-aaff-4f0092924a04"), "Nola.Wiegand@hotmail.com", "Nola", "Wiegand", "1-632-792-5345 x61545", "EG/2037/06555" },
                    { new Guid("ed93b810-3d0b-4ac6-83cf-037358f78146"), "Kristian_Ondricka@hotmail.com", "Kristian", "Ondricka", "(667) 433-9721 x41222", "EG/2042/03737" },
                    { new Guid("f2f460ea-9ef0-43cb-a940-a339f014fa81"), "Adolphus49@hotmail.com", "Adolphus", "Wisozk", "(641) 962-6741 x8055", "EG/2034/01081" }
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
