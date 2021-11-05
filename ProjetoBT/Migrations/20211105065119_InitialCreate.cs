using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    idProcessos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vlCausa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    nmContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nmEscritorio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.idProcessos);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nmUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dcSenhaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processos_ProcessosidProcessos",
                table: "Processos",
                column: "ProcessosidProcessos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
