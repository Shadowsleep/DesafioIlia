using Core.Base;
using Core.Interfaces.Infra;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioBase<T> : IRepositorio<T> where T : Entity
    {
        protected readonly ContextoBancoDeDados _cx;

        public RepositorioBase(ContextoBancoDeDados cx)
        {
            _cx = cx;
        }

        public virtual void Adicionar(T entity)
        {
            _cx.Set<T>().Add(entity);
            _cx.SaveChanges();
        }

        public virtual void Deletar(T entity)
        {
            _cx.Set<T>().Remove(entity);
            _cx.SaveChanges();

        }
        public void Atualizar(T entity)
        {
            _cx.Entry(entity).State = EntityState.Modified;
            _cx.SaveChanges();
        }

        public virtual async Task<IEnumerable<T>> BuscarTodos()
        {
            return await _cx.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> BuscarTodos(ICollection<string> listaIncludes)
        {
            var lista = _cx.Set<T>().AsNoTracking();
            lista = listaIncludes.Aggregate(lista, (current, include) => current.Include(include));

            return await lista.ToListAsync();
        }

        public async Task<T> BuscarPorId(Guid Id, ICollection<string> listaIncludes)
        {
            var lista = _cx.Set<T>().AsQueryable();
            lista = listaIncludes.Aggregate(lista, (current, include) => current.Include(include));
            return await lista.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public virtual async Task<T> BuscarPorId(Guid Id)
        {
            return await _cx.Set<T>().FindAsync(Id);
        }

        public void Dispose()
        {
            _cx?.Dispose();
        }
    }
}