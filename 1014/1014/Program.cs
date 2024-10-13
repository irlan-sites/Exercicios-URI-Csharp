using System.Globalization;

namespace _1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(X/Y).ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}
