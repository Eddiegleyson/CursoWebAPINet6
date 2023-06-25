using ApiCatologo.Models;
using AutoMapper;

namespace ApiCatologo.DTOs.Mappings;

public class MappingProfile : Profile
{
public MappingProfile()
{
    CreateMap<Produto, ProdutoDTO>().ReverseMap();
    CreateMap<Categoria, CategoriaDTO>().ReverseMap();
}
}
