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

            int opcao;
            

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 . Cadastrar Paciente");
                Console.WriteLine("2 . Listar pacientes");
                Console.WriteLine("3 . Atender pacientes da fila");
                Console.WriteLine("4 . Alterar Dados Cadastrais");
                Console.WriteLine("0 . Sair");
                Console.WriteLine("Digite sua opção:");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Paciente p1  = new Paciente();
                        p1.Cadastrar();
                        break;
                    case 2:
                        Console.WriteLine("tudo bem");
                        break;
                    case 3:
                        Console.WriteLine("como vai");
                        break;
                    case 4:
                        Console.WriteLine("olaa");
                        break;
                    case 0:
                        Console.WriteLine("saindo do programa");
                        break;
                    default:
                        Console.WriteLine("opcao invalida");
                        break;
                } 
            } while (opcao != 0);

            Pessoa [] paciente2 = new Pessoa[15];


        }
    }
}






