using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Cola-Cola Diet', 'Refrigerante de 350 ml', 4.50, 'cocacolca.jpg', 200, CURRENT_TIMESTAMP, 1)");

            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Bolacha Recheada', 'Bolacha Recheada de Chocolate Branco 76 G', 2.30, 'bolacharecheada.jpg', 500, CURRENT_TIMESTAMP, 2)");

            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Bolo de Cenoura', 'O bolo de cenoura é um bolo doce com cenoura misturada dentro da massa 500 G.', 8.60, 'bolodecenoura.jpg', 60, CURRENT_TIMESTAMP, 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
