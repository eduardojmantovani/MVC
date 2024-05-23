using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoMVC.Migrations
{
    /// <inheritdoc />
    public partial class alunos4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "diaPagamento",
                table: "Alunos",
                newName: "DiaPagamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiaPagamento",
                table: "Alunos",
                newName: "diaPagamento");
        }
    }
}
