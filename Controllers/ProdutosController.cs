namespace ApiCatologo.Controllers;

using ApiCatologo.DTOs;
using ApiCatologo.Models;
using ApiCatologo.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ProdutosController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet("GetProdutoPorPreco")]
    public ActionResult<IEnumerable<ProdutoDTO>> GetProdutoPreco()
    {
        try
        {
            var produtos = _unitOfWork.ProdutoRepository.GetProdutoPorPreco().ToList();
            var produtosResultDTO = _mapper.Map<List<ProdutoDTO>>(produtos);
            if (produtos is null)
            {
                return NotFound("Lista de Produtos POR PREÇO não encontrado");
            }
            return Ok(produtosResultDTO);
        }
        catch
        {
           return StatusCode(StatusCodes.Status500InternalServerError, $"ocorreu um problema no sistam");
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> Get()
    {
        var produtos = _unitOfWork.ProdutoRepository.Get().AsNoTracking().ToList();
        if (produtos is null)
        {
            return NotFound("Produto não encontrado");
        }
        return produtos;
    }

    [HttpGet("GetById", Name = "ObterProduto")]
    public ActionResult<Produto> Get(int id)
    {
        var produto = _unitOfWork.ProdutoRepository.GetById(p => p.ProdutoId == id);
        if (produto is null)
        {
            return NotFound("Produto não encontardo.");
        }
        return produto;
    }

    [HttpPost]
    public ActionResult Post(Produto produto)
    {
        if (produto is null)
        {
            return BadRequest("Payload Not Found.");
        }
        _unitOfWork.ProdutoRepository.Add(produto);
        _unitOfWork.Commit();
        return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
    }
}
