using System.Globalization;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peca1, peca2;
            int codigo1, codigo2, quantidade1, quantidade2;
            double preco1, preco2, total;

            peca1 = Console.ReadLine().Split();
            peca2 = Console.ReadLine().Split();

            codigo1 = int.Parse(peca1[0]);
            quantidade1 = int.Parse(peca1[1]);
            preco1 = double.Parse(peca1[2]);

            codigo2 = int.Parse(peca2[0]);
            quantidade2 = int.Parse(peca2[1]);
            preco2 = double.Parse(peca2[2]);

            total = preco1 * quantidade1 + preco2 * quantidade2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
