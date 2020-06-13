using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadeDePessoas = 2;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos, mas esta acompanhado entao poode entrar");

                }
                else
                {
                    Console.WriteLine("joão não possui mais de 18 anos, e nao esta acompanhado");
                }
            }

            Console.ReadLine();
        }
    }
}
