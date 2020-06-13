using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalcularPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;
            while (contadorMes <=12)
            {
                //0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Apos"+contadorMes+ " mes, voce tera R$" + valorInvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes ++;
            }
            Console.ReadLine();

        }
    }
}
