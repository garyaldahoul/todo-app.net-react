using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Intiat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Completed = table.Column<bool>(type: "BIT", nullable: false),
                    Important = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
