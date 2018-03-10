using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using RFL.CadastroClientes.Domain.Entities;
using RFL.CadastroClientes.Domain.Interfaces.Repository;
using RFL.CadastroClientes.Infra.Data.Context;

namespace RFL.CadastroClientes.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClientesContext contexto) : base(contexto)
        {
        }

        public Cliente ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override Cliente Adicionar(Cliente entity)
        {

            _context._connection.Execute("spAdicionarClientes", new
            {
                ClienteId = entity.ClienteId,
                Cpf = entity.Cpf,
                Nome = entity.Nome,
                Email = entity.Email,
                Ativo = entity.Ativo,
                DataNascimento = entity.DataNascimento,
                DataCadastro = entity.DataCadastro
            }, commandType: CommandType.StoredProcedure);

            foreach (var endereco in entity.Enderecos)
            {
                _context._connection.Execute("spAdicionarEnderecos", new
                {
                    EnderecoId = endereco.EntityId,
                    Logradouro = endereco.Logradouro,
                }, commandType: CommandType.StoredProcedure);
            }

            return entity;
        }

        public override IEnumerable<Cliente> ObterTodos()
        {
            return _context._connection.Query<Cliente>("spObterTodosClientes",
                commandType: CommandType.StoredProcedure);
        }
    }
}
