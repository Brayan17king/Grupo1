using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacidad",
                table: "salon");

            migrationBuilder.AddColumn<int>(
                name: "CapacidadSalon",
                table: "salon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCiudadFk",
                table: "persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoPersonaFk",
                table: "persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "pais",
                keyColumn: "NombrePais",
                keyValue: null,
                column: "NombrePais",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePais",
                table: "pais",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "matricula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdSalonFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matricula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_matricula_persona_IdPersonaFk",
                        column: x => x.IdPersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_matricula_salon_IdSalonFk",
                        column: x => x.IdSalonFk,
                        principalTable: "salon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_persona_IdCiudadFk",
                table: "persona",
                column: "IdCiudadFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_IdTipoPersonaFk",
                table: "persona",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_matricula_IdPersonaFk",
                table: "matricula",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_matricula_IdSalonFk",
                table: "matricula",
                column: "IdSalonFk");

            migrationBuilder.AddForeignKey(
                name: "FK_persona_ciudad_IdCiudadFk",
                table: "persona",
                column: "IdCiudadFk",
                principalTable: "ciudad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_persona_tipoPersona_IdTipoPersonaFk",
                table: "persona",
                column: "IdTipoPersonaFk",
                principalTable: "tipoPersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persona_ciudad_IdCiudadFk",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_tipoPersona_IdTipoPersonaFk",
                table: "persona");

            migrationBuilder.DropTable(
                name: "matricula");

            migrationBuilder.DropIndex(
                name: "IX_persona_IdCiudadFk",
                table: "persona");

            migrationBuilder.DropIndex(
                name: "IX_persona_IdTipoPersonaFk",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "CapacidadSalon",
                table: "salon");

            migrationBuilder.DropColumn(
                name: "IdCiudadFk",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "IdTipoPersonaFk",
                table: "persona");

            migrationBuilder.AddColumn<int>(
                name: "Capacidad",
                table: "salon",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePais",
                table: "pais",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
