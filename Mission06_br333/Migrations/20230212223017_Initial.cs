using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_br333.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    FormID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<short>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Lent_to = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.FormID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormID", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Denis Villaneuve", false, "Braden", "My favorite movie.", "PG-13", "Dune", (short)2021 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormID", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "James Cameron", false, "Braden", "My favorite new movie.", "PG-13", "Avatar: The Way of Water", (short)2022 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormID", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "James Cameron", false, "Braden", "My favorite older movie.", "PG-13", "Avatar", (short)2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
