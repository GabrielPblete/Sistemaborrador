using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemaborrador.Repositories
{
    public class LoginRepository
    {
        public bool UsuarioExist(string Usuario,string Password)
        {
            bool resultado = false;
            string connectionString = "server=localhost;database= Sistemaborrador;Integrated Security=true;";
            string query1 = "Select count(*) from Usuarios Where usuario= '";
            string query2 = "' and Password= '";
            string query3 = "'";
            string query = query1+Usuario+query2+Password+query3;
            using SqlConnection sql = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, sql);
            sql.Open();
            int queryResult = (int)cmd.ExecuteScalar();
            if (queryResult > 0)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
