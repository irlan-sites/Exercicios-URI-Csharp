namespace _1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorTotal;

            valorTotal = int.Parse(Console.ReadLine());

            Console.WriteLine(valorTotal);
            Console.WriteLine($"{valorTotal / 100} nota(s) de R$ 100,00");
            int resto100 = valorTotal % 100;
            Console.WriteLine($"{resto100 / 50} nota(s) de R$ 50,00");
            int resto50 = resto100 % 50;
            Console.WriteLine($"{resto50 / 20} nota(s) de R$ 20,00");
            int resto20 = resto50 % 20;
            Console.WriteLine($"{resto20 / 10} nota(s) de R$ 10,00");
            int resto10 = resto20 % 10;
            Console.WriteLine($"{resto10 / 5} nota(s) de R$ 5,00");
            int resto5 = resto10 % 5;
            Console.WriteLine($"{resto5 / 2} nota(s) de R$ 2,00");
            int resto2 = resto5 % 2;
            Console.WriteLine($"{resto2 / 1} nota(s) de R$ 1,00");
        }
    }
}