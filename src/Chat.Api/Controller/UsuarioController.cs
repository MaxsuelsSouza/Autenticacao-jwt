using Chat.Api.Dominio.DTOs;
using Chat.Api.Dominio.Usuarios;
using Chat.Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Controller
{
    [ApiController]
    [Route("usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] Usuario usuario)
        {
            var usuariocriar = await _usuarioService.Adicionar(usuario);

            return Ok(usuario);
        }
    }
}