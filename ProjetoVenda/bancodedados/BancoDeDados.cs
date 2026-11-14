using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.bancodedados
{
    internal static class BancoDeDados
    {
        private static string textoDeConexao;


        static BancoDeDados()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "jeff",
                UserID = "root",
                Password = ""
            };
            textoDeConexao = builder.ConnectionString;
        }


        public static MySqlConnection conexao()
        {
            MySqlConnection connection = new MySqlConnection(textoDeConexao);
            try
            {
                connection.Open();
                return connection;
            }catch (MySqlException ex)
            {
                connection.Dispose();
                throw;
            }
        }

    }
}
