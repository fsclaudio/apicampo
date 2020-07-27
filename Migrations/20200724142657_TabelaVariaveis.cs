using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apicampo.Migrations
{
    public partial class TabelaVariaveis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Variaveis",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    varia = table.Column<string>(nullable: false),
                    valor_dia = table.Column<string>(nullable: false),
                    val_safra = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variaveis", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variaveis");
        }
    }
}
