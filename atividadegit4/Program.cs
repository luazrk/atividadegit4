﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadegit4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Resultado da soma {0}+{1}={2}", 3, 5, somar(3, 5));
        }
        public static int somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public static int subtrair(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public static int divisao(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
        public static int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
    }
}
