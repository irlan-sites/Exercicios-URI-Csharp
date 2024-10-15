namespace _1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diasTotal;

            diasTotal = int.Parse(Console.ReadLine());

            Console.WriteLine($"{diasTotal/365} ano(s)");
            int restoAnos = diasTotal % 365;
            Console.WriteLine($"{restoAnos/30} mes(es)");
            int restoMeses = restoAnos % 30;
            Console.WriteLine($"{restoMeses} dia(s)");
        }
    }
}
