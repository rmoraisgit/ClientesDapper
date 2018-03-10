using RFL.CadastroClientes.Domain.Interfaces.Repository;
using RFL.CadastroClientes.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFL.CadastroClientes.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ClientesContext _context { get; set; }

        public Repository(ClientesContext contexto)
        {
            _context = contexto;
        }

        public virtual TEntity Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public virtual void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
