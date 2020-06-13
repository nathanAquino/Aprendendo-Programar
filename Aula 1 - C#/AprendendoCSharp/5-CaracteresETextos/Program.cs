using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5 - Caracteres e textos");

            //character apenas 16 bits
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //string representação de texto
            string titulo = "Alura cursos de Tecnologia " + 2020;
            //@ pega tudo entre varias linhas
            string cursosProgramacao =
@"- .Net
- Java
- JavaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            

            
            Console.ReadLine();
        }
    }
}
