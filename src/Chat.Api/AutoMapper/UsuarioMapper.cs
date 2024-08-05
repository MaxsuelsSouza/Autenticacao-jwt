using AutoMapper;
using Chat.Api.Dominio.DTOs;
using Chat.Api.Dominio.Usuarios;

namespace Chat.Api.AutoMapper;
public class UsuarioMapper : Profile
{
    public UsuarioMapper()
    {
        CreateMap<Usuario, UsuarioNovoDto>().ReverseMap();
        CreateMap<UsuarioNovoDto, Usuario>().ReverseMap();
    }
}
