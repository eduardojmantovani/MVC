using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoMVC.Migrations
{
    /// <inheritdoc />
    public partial class alunos1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "diaPagamento",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diaPagamento",
                table: "Alunos");
        }
    }
}
