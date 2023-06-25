namespace ApiCatologo.Repository;

using ApiCatologo.Models;
public interface ICategoriaRepository : IRepository<Categoria>
{
    IEnumerable<Categoria> ObterCategoriasOrdenadoPorId ();
    IEnumerable<Categoria> GetCategoriaPorProdutos();
}
