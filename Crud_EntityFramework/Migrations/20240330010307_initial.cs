using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Processador = table.Column<string>(type: "TEXT", nullable: false),
                    Placa_Mae = table.Column<string>(type: "TEXT", nullable: false),
                    Memória = table.Column<string>(type: "TEXT", nullable: false),
                    HD = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroPratrimonio = table.Column<int>(type: "INTEGER", nullable: false),
                    Data_compra = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computadores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computadores");
        }
    }
}
