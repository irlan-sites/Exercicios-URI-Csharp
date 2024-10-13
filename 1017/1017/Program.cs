using System.Globalization;

namespace _1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasPercorridas, velocidadeMedia, distanciaPercorrida;
            double litrosNecessarios;

            horasPercorridas = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = horasPercorridas * velocidadeMedia;
            litrosNecessarios = (double)distanciaPercorrida / 12.0;

            Console.WriteLine(litrosNecessarios.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
