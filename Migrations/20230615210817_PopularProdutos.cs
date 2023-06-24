using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatologo.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Produtos (nome, Descricao, preco, ImagemUrl, DataCadastro, CategoriaId) values ('Coca-cola Diet', 'Refrigerante de Coca-cola 300ml',5.45,'cocacola.jpg',now(),1)");
            mb.Sql("insert into Produtos (nome, Descricao, preco, ImagemUrl, DataCadastro, CategoriaId) values ('Lanche de Atum', 'Atum de maionese ',6.45,'atum.jpg',now(),2)");
            mb.Sql("insert into Produtos (nome, Descricao, preco, ImagemUrl, DataCadastro, CategoriaId) values ('Pudim', 'Pudim de Leite 100g',7.45,'Pudim.jpg',now(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
           mb.Sql("delete from Produtos");     
        }
    }
}
