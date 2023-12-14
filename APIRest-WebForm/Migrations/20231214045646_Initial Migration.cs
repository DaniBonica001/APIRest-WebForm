using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIRest_WebForm.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PERSONAS",
                columns: table => new
                {
                    identificador = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    nombre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    apellido = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    numero_identificacion = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    tipo_identificacion = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "date", nullable: false),
                    tipo_numero_identificacion = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    nombre_apellidos = table.Column<string>(type: "varchar(130)", unicode: false, maxLength: 130, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERSONAS__C83612B1C194EA99", x => x.identificador);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    identificador = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    usuario = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    pass = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USUARIO__C83612B1ACBA89BD", x => x.identificador);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERSONAS");

            migrationBuilder.DropTable(
                name: "USUARIO");
        }
    }
}
