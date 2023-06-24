namespace ApiCatologo.Repository;

using ApiCatologo.Models;
public interface  IProdutoRepository : IRepository<Produto>
{
    IEnumerable<Produto> GetProdutoPorPreco();
}
