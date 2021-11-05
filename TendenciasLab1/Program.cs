using System;
using System.Collections.Generic;
using System.Numerics;
// Par? Primo? Digitos
// 50 iteraciones
namespace TendenciasLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Armar(50);
        }
        static void Armar(int n)
        {
            for (int i = 1; i < n; i++)
            {
                int fib = Fibonacci(i);
                string par = EncontrarPar(fib);
                string primo = EncontrarPrimo(fib);
                Console.Write("{0}. {1} : {2}, {3}, '", i, fib, par, primo);
                EncontrarDigitos(fib);
            }
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                n = Fibonacci(n - 1) + Fibonacci(n - 2);
                return n;
            }
        }
        static string EncontrarPar(int n)
        {
            string esPar;
            int mod = n % 2;
            if (mod == 0)
            {
                esPar = "Par";
            }
            else
            {
                esPar = "Impar";
            }

            return esPar;
        }
        static string EncontrarPrimo(int n)
        {
            string esPrimo = "Es primo";
            for (int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                {
                    esPrimo = "No es primo";
                    return esPrimo;
                }
            }
            return esPrimo;
        }
        static void EncontrarDigitos(int n)
        {
            int digito = n;
            List<int> intarray = new List<int>();
            if (digito < 10)
            {
                Console.Write("{0}'{1}", digito, Environment.NewLine);
            }
            else
            {
                while (digito != 0)
                {
                    intarray.Add(digito % 10);
                    digito = digito / 10;
                }
                for (int i = intarray.Count - 1; i > 0; i--)
                {
                    Console.Write("{0},", intarray[i]);
                }
                Console.Write("{0}'{1}", intarray[0], Environment.NewLine);
            }
        }
    }
}
