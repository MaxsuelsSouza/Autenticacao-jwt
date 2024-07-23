using AutoMapper;
using Chat.Api.Dominio.Usuarios;

namespace Chat.Api.Dominio.DTOs;
public class UsuarioDto
{
    public Guid UsuarioId { get; set; }
    public string? NomeUsuario { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
}

