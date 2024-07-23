using Chat.Api.Data;
using Chat.Api.Dominio.DTOs;
using Chat.Api.Dominio.Usuarios;
using Chat.Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Repositorios.Classes;
public class UsuarioRepositorio(AplicacaoContexto context) : IUsuarioRepositorio
{
    private readonly AplicacaoContexto _context = context;

    public async Task<Usuario> Adicionar(Usuario entidade)
    {
        await _context.Usuarios.AddAsync(entidade);
        await _context.SaveChangesAsync();

        return entidade;
    }

    public Task<Usuario> Atualizar(Usuario entidade)
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