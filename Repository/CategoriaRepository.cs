namespace ApiCatologo.Repository;

using ApiCatologo.Context;
using ApiCatologo.Models;
using Microsoft.EntityFrameworkCore;

public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(AppDbContext context) : base(context)
    {

    }

    public IEnumerable<Categoria> GetCategoriaPorProdutos()
    {
        return Get().Include(w => w.Produtos);
    }

    public IEnumerable<Categoria> ObterCategoriasOrdenadoPorId()
    {
        return Get().OrderBy(w => w.CategoriaId).ToList();
    }
}