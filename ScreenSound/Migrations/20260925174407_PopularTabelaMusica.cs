using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string[] { "ArtistaId", "Nome", "AnoLancamento" }, new object[] { 1, "Oceano", 1989 });
            migrationBuilder.InsertData("Musicas", new string[] { "ArtistaId", "Nome", "AnoLancamento" }, new object[] { 2, "Azul da cor do mar", 1980 });
            migrationBuilder.InsertData("Musicas", new string[] { "ArtistaId", "Nome", "AnoLancamento" }, new object[] { 3, "Dois Rios", 2000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas WHERE Nome IN ('Oceano', 'Azul da cor do mar', 'Dois Rios')");
        }
    }
}
