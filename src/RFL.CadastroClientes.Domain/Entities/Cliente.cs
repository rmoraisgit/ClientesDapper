using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFL.CadastroClientes.Domain.Entities
{
    public class Cliente : Entity
    {
        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        public Guid ClienteId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }       
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }  
        public ICollection<Endereco> Enderecos { get; set; }

        public void EstaAtivo()
        {
            Ativo = true;
            Excluido = false;
        }

        public void EstaDesativado()
        {
            Ativo = false;
            Excluido = true;
        }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
