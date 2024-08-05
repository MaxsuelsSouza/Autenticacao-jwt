using AutoMapper;
using Chat.Api.Dominio.Usuarios;

namespace Chat.Api.Dominio.DTOs;
[AutoMap(typeof(Usuario), ReverseMap = true)]
public class UsuarioListarDto
{
    public Guid UsuarioId { get; set; }
    public string? NomeUsuario { get; set; }
    public string? Email { get; set; }
}

