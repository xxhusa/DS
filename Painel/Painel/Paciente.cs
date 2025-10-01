using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painel
{
    public class Paciente : Pessoa
    {
        public int idade;


        public static void Cadastrar()
        {
            Console.WriteLine("Qual seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade:");
            int idade = int.Parse(Console.ReadLine());


            if (idade >= 60)
            {

                Console.WriteLine("Prioridade 1");

            }
            else if (idade <= 17)
            {

                Console.WriteLine("Prioridade 2");

            }
            else
            {

                Console.WriteLine("Prioridade 3");
            }
            Console.WriteLine($"Cadastro realizado com sucesso! nome = {nome} ,idade =  {idade},");
        }
    }
}
