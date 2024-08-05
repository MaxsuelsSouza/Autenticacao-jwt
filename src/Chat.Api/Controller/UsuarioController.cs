using Chat.Api.Dominio.DTOs;
using Chat.Api.Dominio.Usuarios;
using Chat.Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Controller;
[ApiController]
[Route("usuarios")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost("novo-usuario")]
    public async Task<IActionResult> Adicionar([FromBody] UsuarioNovoDto usuario)
    {
        await _usuarioService.Adicionar(usuario);

        return new OkResult();
    }

    [HttpGet("usuarios")]
    public async Task<IActionResult> ObterTodos()
    {
        return Ok(await _usuarioService.ObterTodos());
    }

    [HttpGet("usuario/{usuarioId}")]
    public async Task<IActionResult> Obter(Guid usuarioId)
    {
        await _usuarioService.ObterPorId(usuarioId);

        return new OkResult();
    }
}
