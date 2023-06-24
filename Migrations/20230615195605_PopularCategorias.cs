using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatologo.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Categorias(Nome, ImagemUrl) Values('Bebidas','bebidas.jpg')");
            mb.Sql("insert into Categorias(Nome, ImagemUrl) Values('Lanches','Lanches.jpg')");
            mb.Sql("insert into Categorias(Nome, ImagemUrl) Values('Sobremesas','Sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
           mb.Sql("delete from Categorias");     
        }
    }
}
