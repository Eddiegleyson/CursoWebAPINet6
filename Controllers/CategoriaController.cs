namespace ApiCatologo.Controllers;

using Microsoft.AspNetCore.Mvc;
using ApiCatologo.Models;
using ApiCatologo.Filters;
using ApiCatologo.Repository;

[Route("api/[controller]")]
[ApiController]
public class CategoriaController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    public CategoriaController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet("ObterCategoriasOrdenadoPorId")]
    public ActionResult<IEnumerable<Categoria>> ObterCategoriasOrdenadoPorId()
    {
        try
        {
            var categorias = _unitOfWork.CategoriaRepository.ObterCategoriasOrdenadoPorId().ToList();
            if (categorias is null)
            {
                return NotFound("Lista de Categorias não encontrada");
            }
            return Ok(categorias);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, $"ocorreu um problema no sistam");
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<Categoria>> Get()
    {
        var categorias = _unitOfWork.CategoriaRepository.Get().ToList();
        if (categorias is null)
        {
            return NotFound("Categoria não encontrada");
        }
        return categorias;
    }

    [HttpGet("GetById", Name = "ObterCategoria")]
    public ActionResult<Categoria> Get(int id)
    {
        try
        {
            var Categoria = _unitOfWork.CategoriaRepository.GetById(p => p.CategoriaId == id);
            if (Categoria is null)
            {
                return NotFound($"ID = {id} da Categoria não encontrada");
            }
            return Ok(Categoria);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, $"ocorreu um problema no sistam, Id = {id}, não encontrado.");
        }

    }

    [HttpPost]
    public ActionResult<Categoria> Post(Categoria categoria)
    {
        if (categoria is null)
        {
            return BadRequest("Payload not Found");
        }
        _unitOfWork.CategoriaRepository.Add(categoria);
        _unitOfWork.Commit();
        return new CreatedAtRouteResult("ObterCategoria", new { id = categoria.CategoriaId }, categoria);
    }
}
