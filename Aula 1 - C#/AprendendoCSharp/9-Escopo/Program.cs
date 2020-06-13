using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 9 - Escopo");

            int idadeJoao = 16;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Joao esta acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                mensagemAdicional = "joao nao esta acompanhado";
                Console.WriteLine(mensagemAdicional);
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João possui entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadLine();
        }
    }
}
