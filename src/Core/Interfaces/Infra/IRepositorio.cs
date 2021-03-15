using Core.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Infra
{
    public interface IRepositorio<T> : IDisposable where T : Entity
    {
        void Adicionar(T entity);
        void Atualizar(T entity);
        void Deletar(T entity);

        Task<T> BuscarPorId(Guid Id);
        Task<T> BuscarPorId(Guid Id, ICollection<string> listaIncludes);
        Task<IEnumerable<T>> BuscarTodos();
        Task<IEnumerable<T>> BuscarTodos(ICollection<string> listaIncludes);
    }
}
