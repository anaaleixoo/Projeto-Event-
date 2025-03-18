using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoEvent_.Migrations
{
    /// <inheritdoc />
    public partial class DbEventPlus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instituicao",
                columns: table => new
                {
                    IdTipoEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicao", x => x.IdTipoEvento);
                });

            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.IdInstituicao);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloTipoUsuario = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataEvento = table.Column<DateTime>(type: "DATE", nullable: false),
                    NomeEvento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IdTipoEventos = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_Evento_Instituicao_IdTipoEventos",
                        column: x => x.IdTipoEventos,
                        principalTable: "Instituicao",
                        principalColumn: "IdTipoEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_Instituicoes_IdInstituicao",
                        column: x => x.IdInstituicao,
                        principalTable: "Instituicoes",
                        principalColumn: "IdInstituicao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComentarioEvento",
                columns: table => new
                {
                    IdComentarioEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Exibe = table.Column<bool>(type: "BIT", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentarioEvento", x => x.IdComentarioEvento);
                    table.ForeignKey(
                        name: "FK_ComentarioEvento_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComentarioEvento_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presenca",
                columns: table => new
                {
                    IdPresencaEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Situacao = table.Column<bool>(type: "BIT", nullable: true),
                    UsuarioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presenca", x => x.IdPresencaEvento);
                    table.ForeignKey(
                        name: "FK_Presenca_Evento_EventosID",
                        column: x => x.EventosID,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presenca_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioEvento_IdEvento",
                table: "ComentarioEvento",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioEvento_IdUsuario",
                table: "ComentarioEvento",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdInstituicao",
                table: "Evento",
                column: "IdInstituicao");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdTipoEventos",
                table: "Evento",
                column: "IdTipoEventos");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicao_CNPJ",
                table: "Instituicao",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instituicoes_CNPJ",
                table: "Instituicoes",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Presenca_EventosID",
                table: "Presenca",
                column: "EventosID");

            migrationBuilder.CreateIndex(
                name: "IX_Presenca_UsuarioID",
                table: "Presenca",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentarioEvento");

            migrationBuilder.DropTable(
                name: "Presenca");

            migrationBuilder.DropTable(
                name: "TipoUsuario");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Instituicao");

            migrationBuilder.DropTable(
                name: "Instituicoes");
        }
    }
}
