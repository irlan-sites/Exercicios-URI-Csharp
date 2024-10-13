using System;
using System.Globalization;
using System.Formats.Asn1;

namespace _1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, area;

            Console.Write("Digite o Valor do Raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(raio, 2.0);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
