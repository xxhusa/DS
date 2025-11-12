using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Painel
{
    class PacienteDAO
    {
        private Conexao conexao = new Conexao();

        public void Inserir(Paciente p)
        {
            var conn = conexao.Abrir();

            string sql = "INSERT INTO paciente (Nome, Idade) VALUES (@Nome, @Idade)";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", p.Nome);
                cmd.Parameters.AddWithValue("@Idade", p.Idade);
                int linhas = cmd.ExecuteNonQuery();
                Console.WriteLine($"{linhas} paciente(s) cadastrado(s).");

            }
        }
        public void Mostrar()
        {
            var conn = conexao.Abrir();
            string sql = "SELECT Id, Nome, Idade FROM paciente";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string nome = reader.GetString("Nome");
                    int idade = Convert.ToInt32(reader["idade"]);
                    Console.WriteLine($"ID: {id} Nome: {nome} Idade: {idade}");


                }

            }
            conn.Close();
        }


        public void AlterarCadastro()
        {
            Console.WriteLine("Digite o ID do Paciente para Alterar os Dados:");
            int idParaAtualizar = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o novo nome:");
            string NovoNome = Console.ReadLine();

            Console.WriteLine("Digite a nova idade:");
            int Novaidade = int.Parse(Console.ReadLine());

            try
            {
                var conn = conexao.Abrir();

                string sql = "UPDATE paciente SET Nome=@nome , Idade=@idade WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", NovoNome);
                cmd.Parameters.AddWithValue("@idade", Novaidade);
                cmd.Parameters.AddWithValue("@id", idParaAtualizar);
                int alterados = cmd.ExecuteNonQuery();
                Console.WriteLine($"{alterados} registro(s) atualizado(s).");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Ocorreu um erro ao atualizar o aluno!");
                Console.WriteLine($"Detalhes: {erro.Message}");
                Console.ReadKey();
            }
        }
        public void DeletarCadastro()
        {
            Console.WriteLine("Digite o ID do aluno que deseja excluir:");
            int idParaExcluir = int.Parse(Console.ReadLine());

            try
            {
                var conn = conexao.Abrir();
                string sql = "DELETE FROM paciente WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", idParaExcluir);
                int removidos = cmd.ExecuteNonQuery();
                Console.WriteLine($"{removidos} registro(s) excluído(s).");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Ocorreu um erro ao deletar o Paciente!");
                Console.WriteLine($"Detalhes: {erro.Message}");
                Console.ReadKey();
            }
        }

        public void AtenderPaciente()
        {


            var conn = conexao.Abrir();
            string sql = "SELECT Id, Nome, Idade FROM paciente ORDER BY Idade DESC";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine(" Atendimento de pacientes na ordem de cadastro");

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string nome = reader.GetString("Nome");
                    int idade = Convert.ToInt32(reader["Idade"]);

                    Console.WriteLine($"Chamando paciente: {nome} (Idade: {idade})");


                    Console.WriteLine("Pressione ENTER para atender o próximo paciente...");
                    Console.ReadLine();
                }

            }


        }
    }

}