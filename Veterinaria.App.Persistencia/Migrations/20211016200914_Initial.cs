using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.App.Persistencia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "estadosalud",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    temperatura = table.Column<double>(type: "float", nullable: false),
                    Frecu_Respi = table.Column<double>(type: "float", nullable: false),
                    Frecu_Cardia = table.Column<double>(type: "float", nullable: false),
                    Estado_Animo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recomendacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    masco_estadosalud = table.Column<int>(type: "int", nullable: false),
                    visit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadosalud", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mascota",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_Mascota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_Salud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dueño = table.Column<int>(type: "int", nullable: false),
                    Nombre_dueño = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mascota", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarjeta_Profesional = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "visita",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Motivo_Visita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    veterinario_visitaId = table.Column<int>(type: "int", nullable: true),
                    mascotaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visita", x => x.id);
                    table.ForeignKey(
                        name: "FK_visita_mascota_mascotaid",
                        column: x => x.mascotaid,
                        principalTable: "mascota",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visita_personas_veterinario_visitaId",
                        column: x => x.veterinario_visitaId,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visita_mascotaid",
                table: "visita",
                column: "mascotaid");

            migrationBuilder.CreateIndex(
                name: "IX_visita_veterinario_visitaId",
                table: "visita",
                column: "veterinario_visitaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "estadosalud");

            migrationBuilder.DropTable(
                name: "visita");

            migrationBuilder.DropTable(
                name: "mascota");

            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
