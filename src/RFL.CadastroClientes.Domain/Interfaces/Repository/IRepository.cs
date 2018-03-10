using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFL.CadastroClientes.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        TEntity Atualizar(TEntity entity);
        void Remover(Guid id);
        TEntity ObterPorId(Guid id);
        IEnumerable<TEntity> ObterTodos();
    }
}
