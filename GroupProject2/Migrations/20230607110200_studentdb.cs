using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupProject2.Migrations
{
    /// <inheritdoc />
    public partial class studentdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    GPA = table.Column<double>(type: "REAL", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Subject1 = table.Column<string>(type: "TEXT", nullable: true),
                    Subject2 = table.Column<string>(type: "TEXT", nullable: true),
                    Subject3 = table.Column<string>(type: "TEXT", nullable: true),
                    Subject4 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDb", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDb");
        }
    }
}
