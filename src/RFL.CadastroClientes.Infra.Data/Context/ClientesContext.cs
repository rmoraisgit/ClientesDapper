using RFL.CadastroClientes.Infra.Data.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFL.CadastroClientes.Infra.Data.Context
{
    public class ClientesContext : IDisposable
    {
        public SqlConnection _connection { get; set; }

        public ClientesContext()
        {
            _connection = new SqlConnection(Settings.strConnection);
            _connection.Open();
        }

        public void Dispose()
        {
            if(_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
    }
}
