using System;

namespace MyApp
{
    internal class Program
    {
        static void Print(string message)
        {
            Console.WriteLine(message);
        }

        static double CalcularAreaCirculo(double raio)
        {
            double saida = Math.PI * Math.Pow(raio, 2);
            return saida;
        }

        static void Main(string[] args)
        {
            Print("Hello World!");
            double area = CalcularAreaCirculo(12);
            Print(area.ToString());
        }
    }
}
