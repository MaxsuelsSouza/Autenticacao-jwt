using AutoMapper;
using Chat.Api.Dominio.DTOs;
using Chat.Api.Dominio.Usuarios;
using Chat.Api.Repositorios.Interfaces;
using Chat.Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Services.Classe;
public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepositorio _repositorioUsuario;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepositorio repositorioUsuario, IMapper mapper)
    {
        _repositorioUsuario = repositorioUsuario;
        _mapper = mapper;
    }

    public async Task<Usuario> Adicionar(Usuario entity)
    {
        var usuario = _mapper.Map<Usuario>(entity);

        usuario = await _repositorioUsuario.Adicionar(usuario);

        return _mapper.Map<Usuario>(usuario);
    }

    public Task<Usuario> Atualizar(Usuario entity)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioDto> Autenticar(string email, string senha)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> ObterPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Usuario>> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public Task<OkResult> Remover(Guid id)
    {
        throw new NotImplementedException();
    }
}