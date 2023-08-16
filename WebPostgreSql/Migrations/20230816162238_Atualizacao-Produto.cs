using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebPostgreSql.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Valor",
                table: "Produto",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Produto");
        }
    }
}
