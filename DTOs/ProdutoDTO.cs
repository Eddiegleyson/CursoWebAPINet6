namespace ApiCatologo.DTOs;

public class ProdutoDTO
{
    public int ProdutoId { get; set; }
    public string? nome { get; set; }
    public string? Descricao { get; set; }
    public decimal? preco { get; set; }
    public string? ImagemUrl { get; set; }
}
