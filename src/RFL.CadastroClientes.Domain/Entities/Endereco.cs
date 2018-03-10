using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFL.CadastroClientes.Domain.Entities
{
    public class Endereco : Entity
    {
        public Endereco()
        {
            
        }

        public Guid ClienteId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
