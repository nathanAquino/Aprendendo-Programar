using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario = 1200.50;
            
            // O int e uma variavel de 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            Console.WriteLine(salarioEmInteiro);

            // O long e uma variavel de 64 bits
            long idade = 1300000000;
            Console.WriteLine(idade);

            // O short e uma variavel de 64 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.ReadLine();

        }
    }
}
