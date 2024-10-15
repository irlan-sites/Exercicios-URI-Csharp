using System.Globalization;

namespace _1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] par1;
            string[] par2;
            double x1, y1, x2, y2, distancia;

            par1 = Console.ReadLine().Split(' ');
            par2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(par1[0]);
            y1 = double.Parse(par1[1]);

            x2 = double.Parse(par2[0]);
            y2 = double.Parse(par2[1]);

            distancia = Math.Sqrt(Math.Pow(x2-x1, 2.0) + Math.Pow(y2-y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
