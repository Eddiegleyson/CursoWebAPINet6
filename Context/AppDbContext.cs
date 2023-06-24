namespace ApiCatologo.Context;

using Microsoft.EntityFrameworkCore;
using ApiCatologo.Models;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }

    public DbSet<Cliente> Clientes{get; set;}

}