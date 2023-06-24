using ApiCatologo.Context;
using ApiCatologo.Models;

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
    }
}