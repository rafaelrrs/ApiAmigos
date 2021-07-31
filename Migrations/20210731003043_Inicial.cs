using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAmigos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amigos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameMother = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameDad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Name", "NameDad", "NameMother" },
                values: new object[] { 1, 8527410, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafael", "Nome do Pai 1", "Nome do Mãe 1" });

            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Name", "NameDad", "NameMother" },
                values: new object[] { 2, 148522, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafa", "Nome do Pai 2", "Nome do Mãe 2" });

            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Name", "NameDad", "NameMother" },
                values: new object[] { 3, 36936936, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Leafar", "Nome do Pai 3", "Nome do Mãe 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amigos");
        }
    }
}
