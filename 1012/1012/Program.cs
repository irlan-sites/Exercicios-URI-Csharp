using System.Globalization;

namespace _1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            double A, B, C;

            valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0]);
            B = double.Parse(valores[1]);
            C = double.Parse(valores[2]);

            Console.WriteLine($"TRIANGULO: {(A*C/2.0).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {(3.14159 * Math.Pow(C, 2.0)).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {((A+B)*C/2.0).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {Math.Pow(B, 2.0).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {(A*B).ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
