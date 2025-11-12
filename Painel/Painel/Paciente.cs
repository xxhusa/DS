using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painel
{
    public class Paciente
    {
        
        public int Idade;
        public string Nome;


        public  void Cadastrar()
        {
            Console.WriteLine("Qual seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade:");
            Idade = int.Parse(Console.ReadLine());


            if (Idade >= 60)
            {

                Console.WriteLine("Prioridade 1");

            }
            else if (Idade <= 17)
            {

                Console.WriteLine("Prioridade 2");

            }
            else
            {

                Console.WriteLine("Prioridade 3");
            }
            Console.WriteLine($"Cadastro realizado com sucesso! nome = {Nome} ,idade =  {Idade},");
        }
    }
}
