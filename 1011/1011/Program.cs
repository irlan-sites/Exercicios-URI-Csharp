using System.Globalization;

namespace _1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;

            raio = double.Parse(Console.ReadLine());
            volume = (4.0 / 3.0) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
