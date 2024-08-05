using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using Chat.Api.AutoMapper;
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
    public async Task<Guid> Adicionar(UsuarioNovoDto entity)
    {
        Usuario usuario = new()
        {
            UsuarioId = Guid.NewGuid(),
            Nome = entity.Nome,
            Sobrenome = entity.Sobrenome,
            NomeUsuario = entity.NomeUsuario,
            Email = entity.Email,
            Senha = GeraHashSenha(entity.Senha!)
        };

        await _repositorioUsuario.Adicionar(usuario);

        return usuario.UsuarioId;
    }

    public Task<UsuarioNovoDto> Atualizar(UsuarioNovoDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioNovoDto> Autenticar(string email, string senha)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioNovoDto> ObterPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<UsuarioNovoDto>> ObterTodos()
    {
        var usuarios = await _repositorioUsuario.ObterTodos();

        return usuarios.Select(usuario => _mapper.Map<UsuarioNovoDto>(usuario));
    }

    public Task<OkResult> Remover(Guid id)
    {
        throw new NotImplementedException();
    }

    private static string GeraHashSenha(string senha)
    {
        string hashSenha;
        byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);
        byte[] bytesHashSenha = SHA256.HashData(bytesSenha);
        hashSenha = BitConverter.ToString(bytesHashSenha).Replace("-", "").Replace("-", "").ToLower();
        return hashSenha;
    }
}


// public async Task<Guid> Adicionar(UsuarioNovoDto entity)
//     {
//         Usuario usuario = new()
//         {
//             UsuarioId = Guid.NewGuid(),
//             Nome = entity.Nome,
//             Sobrenome = entity.Sobrenome,
//             NomeUsuario = entity.NomeUsuario,
//             Email = entity.Email,
//             Senha = GeraHashSenha(entity.Senha!)
//         };

//         await _repositorioUsuario.Adicionar(usuario);

//         return usuario.UsuarioId;
//     }

//     public Task<UsuarioNovoDto> Atualizar(UsuarioNovoDto entity)
//     {
//         throw new NotImplementedException();
//     }

//     public Task<UsuarioNovoDto> Autenticar(string email, string senha)
//     {
//         throw new NotImplementedException();
//     }

//     public async Task<UsuarioNovoDto> Obter(Guid UsuarioId)
//     {
//         var usuario = await _repositorioUsuario.ObterPorId(UsuarioId);

//         return _mapper.Map<UsuarioNovoDto>(usuario);
//     }

//     public async Task<IEnumerable<UsuarioListaDto>> ObterTodos()
//     {
//         var usuarios = await _repositorioUsuario.ObterTodos();

//         return usuarios.Select(usuario => _mapper.Map<UsuarioListaDto>(usuarios));
//     }

//     public Task<OkResult> Remover(Guid UsuarioId)
//     {
//         return _repositorioUsuario.Remover(UsuarioId);
//     }

//     private static string GeraHashSenha(string senha)
//     {
//         string hashSenha;
//         byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);
//         byte[] bytesHashSenha = SHA256.HashData(bytesSenha);
//         hashSenha = BitConverter.ToString(bytesHashSenha).Replace("-", "").Replace("-", "").ToLower();
//         return hashSenha;
//     }