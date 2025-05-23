﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuCRUDApi.Migrations
{
    /// <inheritdoc />
    public partial class VinculoTarefaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Tarefas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_UsuarioID",
                table: "Tarefas",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Usuarios_UsuarioID",
                table: "Tarefas",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Usuarios_UsuarioID",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_UsuarioID",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Tarefas");
        }
    }
}
