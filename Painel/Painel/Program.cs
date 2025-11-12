using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 . Cadastrar Paciente");
                Console.WriteLine("2 . Listar pacientes");
                Console.WriteLine("3 . Atender pacientes da fila");
                Console.WriteLine("4 . Alterar Dados Cadastrais");
                Console.WriteLine("5 . Deletar Paciente"); 
                Console.WriteLine("Q . Sair");
                Console.WriteLine("Digite sua opção:");

                opcao = Console.ReadLine().ToUpper();

                PacienteDAO dao = new PacienteDAO();

                switch (opcao)
                {

                    case "1":
                        Paciente p = new Paciente();
                        p.Cadastrar();
                        dao.Inserir(p);
                        Console.WriteLine("\nPaciente cadastrado e colocado na fila com sucesso!");
                        Console.ReadKey(); 

                        break;

                    case "2":
                        Console.WriteLine("Listar pacientes");

                        
                        dao.Mostrar();
                        Console.ReadKey();

                        break;

                    case "3":

                        Console.WriteLine("Atender pacientes da fila");
                        dao.AtenderPaciente();
                        break;

                    case "4":
                        Console.WriteLine("Alterar Dados Cadastrais dos Pacientes");

                        dao.AlterarCadastro();
                        Console.ReadKey();


                        break;

                    case "5":
                        Console.WriteLine("Deletar Paciente");

                        dao.DeletarCadastro();
                        Console.ReadKey();

                        break;

                    case "Q":

                        Console.WriteLine("saindo do programa");

                        break;

                    default:

                        Console.WriteLine("opcao invalida");

                        break;
                } 
            } while (opcao != "Q");

            


        }
    }
}






