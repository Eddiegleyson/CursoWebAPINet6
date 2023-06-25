namespace ApiCatologo.Repository;

using ApiCatologo.Models;
using ApiCatologo.Pagination;

public interface  IProdutoRepository : IRepository<Produto>
{
    IEnumerable<Produto> GetProdutoPorPreco();
    IEnumerable<Produto> GetProdutosToPageSize(ProdutosParameters produtosParameters);
}
