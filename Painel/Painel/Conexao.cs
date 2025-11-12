using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painel
{
     class Conexao
    {

        private string connectionString = "server=localhost;uid=root;pwd=root;database=hospital;port=3306";



        public MySqlConnection Abrir()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (MySqlException erro)
            {
                Console.WriteLine($"Erro ao conectar: {erro.Message}");
                return null;
            }
        }


    }
}

    

