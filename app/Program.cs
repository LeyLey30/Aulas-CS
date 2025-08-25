using System;

namespace ExerciciosMetodos
{
    internal class Program
    {
        static double CalcularAreaCirculo(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        static int AddNumbers(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static string Saudacao(string userName)
        {
            return $"Olá, {userName}! Bem-vindo!";
        }

        static double CalculateRectangleArea(double comprimento, double largura)
        {
            return comprimento * largura;
        }

        static double CalculateTriangleArea(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            // Parte 1 - Área do círculo
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            double areaCirculo = CalcularAreaCirculo(raio);
            Console.WriteLine($"{nome}, a área do círculo é: {areaCirculo:F2}");
            Console.WriteLine();

            // Parte 2 - Teste AddNumbers
            Console.WriteLine("=== Teste AddNumbers ===");
            Console.WriteLine($"5 + 7 = {AddNumbers(5, 7)}");
            Console.WriteLine($"10 + 20 = {AddNumbers(10, 20)}");
            Console.WriteLine();

            // Parte 3 - Teste Saudacao
            Console.WriteLine("=== Teste Saudacao ===");
            Console.WriteLine(Saudacao("Wesley"));
            Console.WriteLine();

            // Parte 4 - Teste Áreas
            Console.WriteLine("=== Teste Áreas ===");
            Console.WriteLine($"Área do retângulo (5 x 3): {CalculateRectangleArea(5, 3)}");
            Console.WriteLine($"Área do triângulo (base 10, altura 4): {CalculateTriangleArea(10, 4)}");
            Console.WriteLine();

            // Parte 5 - Teste Multiply
            Console.WriteLine("=== Teste Multiply ===");
            Console.WriteLine($"Multiplicação de inteiros (6 * 4): {Multiply(6, 4)}");
            Console.WriteLine($"Multiplicação de doubles (2.5 * 3.2): {Multiply(2.5, 3.2)}");
        }
    }
}
