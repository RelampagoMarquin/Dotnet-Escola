using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola.Migrations
{
    /// <inheritdoc />
    public partial class alter_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Alunos_AlunoId",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Alunos_AlunoId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Disciplinas",
                table: "Disciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Disciplinas",
                newName: "disciplinas");

            migrationBuilder.RenameTable(
                name: "Cursos",
                newName: "cursos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "alunos");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplinas_CursoId",
                table: "disciplinas",
                newName: "IX_disciplinas_CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplinas_AlunoId",
                table: "disciplinas",
                newName: "IX_disciplinas_AlunoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_AlunoId",
                table: "cursos",
                newName: "IX_cursos_AlunoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_disciplinas",
                table: "disciplinas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cursos",
                table: "cursos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_alunos",
                table: "alunos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cursos_alunos_AlunoId",
                table: "cursos",
                column: "AlunoId",
                principalTable: "alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_disciplinas_alunos_AlunoId",
                table: "disciplinas",
                column: "AlunoId",
                principalTable: "alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_disciplinas_cursos_CursoId",
                table: "disciplinas",
                column: "CursoId",
                principalTable: "cursos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cursos_alunos_AlunoId",
                table: "cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_disciplinas_alunos_AlunoId",
                table: "disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_disciplinas_cursos_CursoId",
                table: "disciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_disciplinas",
                table: "disciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cursos",
                table: "cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_alunos",
                table: "alunos");

            migrationBuilder.RenameTable(
                name: "disciplinas",
                newName: "Disciplinas");

            migrationBuilder.RenameTable(
                name: "cursos",
                newName: "Cursos");

            migrationBuilder.RenameTable(
                name: "alunos",
                newName: "Alunos");

            migrationBuilder.RenameIndex(
                name: "IX_disciplinas_CursoId",
                table: "Disciplinas",
                newName: "IX_Disciplinas_CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_disciplinas_AlunoId",
                table: "Disciplinas",
                newName: "IX_Disciplinas_AlunoId");

            migrationBuilder.RenameIndex(
                name: "IX_cursos_AlunoId",
                table: "Cursos",
                newName: "IX_Cursos_AlunoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disciplinas",
                table: "Disciplinas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Alunos_AlunoId",
                table: "Cursos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Alunos_AlunoId",
                table: "Disciplinas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id");
        }
    }
}
