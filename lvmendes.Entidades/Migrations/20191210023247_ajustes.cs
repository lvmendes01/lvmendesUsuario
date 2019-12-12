using Microsoft.EntityFrameworkCore.Migrations;

namespace lvmendes.Entidades.Migrations
{
    public partial class ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Autorizacao",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorizacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sistema",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    AutorizacoesId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Autorizacao_AutorizacoesId",
                        column: x => x.AutorizacoesId,
                        principalSchema: "dbo",
                        principalTable: "Autorizacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SistemaId = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    AutorizacoesId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfil_Autorizacao_AutorizacoesId",
                        column: x => x.AutorizacoesId,
                        principalSchema: "dbo",
                        principalTable: "Autorizacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Perfil_Sistema_SistemaId",
                        column: x => x.SistemaId,
                        principalSchema: "dbo",
                        principalTable: "Sistema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_AutorizacoesId",
                schema: "dbo",
                table: "Perfil",
                column: "AutorizacoesId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_SistemaId",
                schema: "dbo",
                table: "Perfil",
                column: "SistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AutorizacoesId",
                schema: "dbo",
                table: "Usuario",
                column: "AutorizacoesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perfil",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sistema",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Autorizacao",
                schema: "dbo");
        }
    }
}
