using ApiCatologo.Context;
using ApiCatologo.Models;
using ApiCatologo.Pagination;

namespace ApiCatologo.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context)
        {

        }
        public IEnumerable<Produto> GetProdutoPorPreco()
        {
            return Get().OrderBy( c=> c.preco).ToList();
        }

        public IEnumerable<Produto> GetProdutosToPageSize(ProdutosParameters produtosParameters)
        {
            return Get()
            .OrderBy(on => on.nome)
            .Skip((produtosParameters.PageNumber - 1) * produtosParameters.PageSize)
            .Take(produtosParameters.PageSize)
            .ToList();
        }
    }
}