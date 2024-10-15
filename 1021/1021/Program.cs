namespace _1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valorTotal;

            valorTotal = Console.ReadLine().Split('.');
            int cedulas = int.Parse(valorTotal[0]);
            int moedas = int.Parse(valorTotal[1]);

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{cedulas / 100} nota(s) de R$ 100,00");
            int resto100 = cedulas % 100;
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
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{resto2} moeda(s) de R$ 1,00");
            Console.WriteLine($"{moedas / 50} moeda(s) de R$ 0,50");
            int restoMoeda50 = moedas % 50;
            Console.WriteLine($"{restoMoeda50 / 25} moeda(s) de R$ 0,25");
            int restoMoeda25 = restoMoeda50 % 25;
            Console.WriteLine($"{restoMoeda25 / 10} moeda(s) de R$ 0,10");
            int restoMoeda10 = restoMoeda25 % 10;
            Console.WriteLine($"{restoMoeda10 / 5} moeda(s) de R$ 0,05");
            int restoMoeda5 = restoMoeda10 % 5;
            Console.WriteLine($"{restoMoeda5} moeda(s) de R$ 0,01");
        }
    }
}
