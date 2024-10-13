using System.Globalization;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, parteVariavel, salarioTotal;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            parteVariavel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioTotal = salarioFixo + (parteVariavel * 0.15);

            Console.WriteLine($"TOTAL = R$ {salarioTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
