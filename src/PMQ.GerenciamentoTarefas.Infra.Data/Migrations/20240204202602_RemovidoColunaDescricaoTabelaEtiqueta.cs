using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMQ.GerenciamentoTarefas.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovidoColunaDescricaoTabelaEtiqueta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRICAO",
                table: "ETIQUETA");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "TAREFA",
                type: "NVARCHAR2(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "TAREFA",
                type: "NVARCHAR2(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "DESCRICAO",
                table: "ETIQUETA",
                type: "NVARCHAR2(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
