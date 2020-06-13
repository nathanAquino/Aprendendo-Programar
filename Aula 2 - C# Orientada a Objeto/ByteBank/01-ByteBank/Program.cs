using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            ContaCorrente contaDaManu = new ContaCorrente();

            contaDaGabriela.titular = "Gabriella";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numeroAgencia = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero da Agencia: " + contaDaGabriela.numeroAgencia);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

                        
            Console.ReadLine();

                
        }
    }
}
