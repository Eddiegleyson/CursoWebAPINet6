namespace ApiCatologo.Repository;

using ApiCatologo.Context;
using ApiCatologo.Models;

public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(AppDbContext context) : base(context)
    {

    }
    public IEnumerable<Categoria> ObterCategoriasOrdenadoPorId()
    {
        return Get().OrderBy(w => w.CategoriaId).ToList();
    }
}