using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaWebAPI.Util
{
    public class DAL
    {
        private static string Server = "DESKTOP-GKDAB9R\\SQLEXPRESS";
        private static string Database = "DB_CLIENTE";
        private static string User = "SA";
        private static string Password = "123456";
        private SqlConnection Connection;

        private string connectionString = "Server=" + Server + ";Database=" + Database + ";User Id=" + User + ";Password="+ Password+ ";";

        public DAL()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        /// <summary>
        /// Executa comandos do tipo Insert, Update e Delete
        /// </summary>
        /// <param name="query"></param>
        public void ExecutarComandoSQL(string query)
        {
            SqlCommand command = new SqlCommand(query, Connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Executa comandos do tipo Select e retorna registros existentes
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable RetornarDados(string query)
        {
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable Dados = new DataTable();
            sqlDataAdapter.Fill(Dados);
            return Dados;
        }
    }
}
