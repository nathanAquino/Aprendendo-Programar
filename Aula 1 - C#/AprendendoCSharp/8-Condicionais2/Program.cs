﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            //int quantidadeDePessoas = 2;
            //bool acompanhado = quantidadeDePessoas >=2;
            bool acompanhado = false;
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João possui entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
