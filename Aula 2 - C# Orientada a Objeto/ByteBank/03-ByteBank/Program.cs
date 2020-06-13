using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriella = new ContaCorrente();
            contaDaGabriella.titular = "gabriella";
            contaDaGabriella.agencia = 863;
            contaDaGabriella.numeroAgencia = 863452;

            ContaCorrente contaDaGabriellaCosta = new ContaCorrente();
            contaDaGabriellaCosta.titular = "gabriella costa";
            contaDaGabriellaCosta.agencia = 863;
            contaDaGabriellaCosta.numeroAgencia = 863452;

            contaDaGabriella = contaDaGabriellaCosta;
            Console.WriteLine(contaDaGabriella == contaDaGabriellaCosta);

            contaDaGabriella.saldo = 300;
            Console.WriteLine(contaDaGabriella.saldo);
            Console.WriteLine(contaDaGabriellaCosta.saldo);

            if(contaDaGabriella.saldo >= 100)
            {
                contaDaGabriella.saldo -= 100;
            }

            Console.ReadLine();
        }
    }
}
