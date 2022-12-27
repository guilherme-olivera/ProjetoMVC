using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO categorias(categoriaNome,Descricao)" +
                "VALUES ('Normal', 'Lanche feito com igredientes normais')");

            migrationBuilder.Sql("INSERT INTO categorias(categoriaNome,Descricao)" +
                "VALUES ('Natural', 'Lanche feito com igredientes integrais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
