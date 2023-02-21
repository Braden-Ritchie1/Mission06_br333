using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_br333.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    FormID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryID = table.Column<int>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_responses_category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormID", "CategoryID", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Denis Villaneuve", false, "Braden", "My favorite movie.", "PG-13", "Dune", (short)2021 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormID", "CategoryID", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 1, "James Cameron", false, "Braden", "My favorite new movie.", "PG-13", "Avatar: The Way of Water", (short)2022 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormID", "CategoryID", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 1, "James Cameron", false, "Braden", "My favorite older movie.", "PG-13", "Avatar", (short)2009 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryID",
                table: "responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
