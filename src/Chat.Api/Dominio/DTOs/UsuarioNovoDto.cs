using AutoMapper;
using Chat.Api.Dominio.Usuarios;

namespace Chat.Api.Dominio.DTOs;
[AutoMap(typeof(Usuario), ReverseMap = true)]
public class UsuarioNovoDto
{
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? NomeUsuario { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
}

