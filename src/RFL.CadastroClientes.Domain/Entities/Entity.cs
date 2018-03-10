using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFL.CadastroClientes.Domain.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            EntityId = Guid.NewGuid();
        }

        public Guid EntityId { get; set; }

        public abstract bool EhValido();
    }
}
