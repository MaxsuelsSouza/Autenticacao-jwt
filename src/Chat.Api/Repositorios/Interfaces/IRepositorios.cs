using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Repositorios.Interfaces;
    public interface IRepositorios<T, I> where T : class
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(I id);
        Task<T> Adicionar(T entidade);
        Task<T> Atualizar(T entidade);
        Task<OkResult> Remover(I id);
    }