using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIRestWebForm.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PERSONAS",
                columns: table => new
                {
                    identificador = table.Column<Guid>(type: "uuid", nullable: false),
                    nombre = table.Column<string>(type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    apellido = table.Column<string>(type: "character varying(100)", unicode: false, maxLength: 100, nullable: true),
                    numeroidentificacion = table.Column<string>(name: "numero_identificacion", type: "character varying(20)", unicode: false, maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "character varying(40)", unicode: false, maxLength: 40, nullable: true),
                    tipoidentificacion = table.Column<string>(name: "tipo_identificacion", type: "character varying(5)", unicode: false, maxLength: 5, nullable: true),
                    fechacreacion = table.Column<DateTime>(name: "fecha_creacion", type: "date", nullable: false),
                    tiponumeroidentificacion = table.Column<string>(name: "tipo_numero_identificacion", type: "character varying(30)", unicode: false, maxLength: 30, nullable: true),
                    nombreapellidos = table.Column<string>(name: "nombre_apellidos", type: "character varying(130)", unicode: false, maxLength: 130, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERSONAS__C83612B1B64D74CB", x => x.identificador);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    identificador = table.Column<Guid>(type: "uuid", nullable: false),
                    usuario = table.Column<string>(type: "character varying(15)", unicode: false, maxLength: 15, nullable: true),
                    pass = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    fechacreacion = table.Column<DateTime>(name: "fecha_creacion", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USUARIO__C83612B124CA4351", x => x.identificador);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERSONAS");

            migrationBuilder.DropTable(
                name: "USUARIO");
        }
    }
}
