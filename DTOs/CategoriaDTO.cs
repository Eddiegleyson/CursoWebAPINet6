namespace ApiCatologo.DTOs;

public class CategoriaDTO
{
    public int CategoriaId { get; set; }
    public string? nome { get; set; }
    public string? ImagemUrl { get; set; }
    public ICollection<ProdutoDTO>? Produtos { get; set; }
}
