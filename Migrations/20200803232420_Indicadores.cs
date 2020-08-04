using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apicampo.Migrations
{
    public partial class Indicadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Indcadores",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    VARIAVEL = table.Column<string>(nullable: true),
                    DATA = table.Column<string>(nullable: true),
                    HORA = table.Column<string>(nullable: true),
                    VALOR = table.Column<string>(nullable: true),
                    DESCRICAO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indcadores", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indcadores");
        }
    }
}
