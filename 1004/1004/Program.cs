using System.Net.Http.Headers;

namespace _1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            PROD = A * B;

            Console.WriteLine($"PROD = {PROD}");
        }
    }
}
