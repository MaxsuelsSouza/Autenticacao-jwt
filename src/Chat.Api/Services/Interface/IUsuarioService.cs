using Chat.Api.Dominio.DTOs;
using Chat.Api.Dominio.Usuarios;

namespace Chat.Api.Services.Interface;
public interface IUsuarioService : IService<UsuarioNovoDto>
{
    Task<UsuarioNovoDto> Autenticar(string email, string senha);
}