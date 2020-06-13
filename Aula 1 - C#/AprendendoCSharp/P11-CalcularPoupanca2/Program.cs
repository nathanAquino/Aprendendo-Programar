using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalcularPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes=1;contadorMes <=12;contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine(
                    "apos" + contadorMes +
                    "meses, voce tera R$" + valorInvestido);
            }
            Console.ReadLine();
        }
    }
}
