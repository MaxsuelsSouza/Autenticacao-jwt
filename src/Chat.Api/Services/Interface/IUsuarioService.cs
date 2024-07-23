using Chat.Api.Dominio.DTOs;
using Chat.Api.Dominio.Usuarios;

namespace Chat.Api.Services.Interface;
public interface IUsuarioService : IService<Usuario>
{
    Task<UsuarioDto> Autenticar(string email, string senha);
}