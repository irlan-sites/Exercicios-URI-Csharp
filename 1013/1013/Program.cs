namespace _1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int A, B, C, m, M;

            valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            m = (A + B + Math.Abs(A - B)) / 2;
            M = (m + C + Math.Abs(m - C)) / 2;

            Console.WriteLine($"{M} eh o maior");
        }
    }
}
