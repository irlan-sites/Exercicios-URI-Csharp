namespace _1019_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundosTotal;

            segundosTotal = int.Parse(Console.ReadLine());
            int horas = segundosTotal / 3600;
            int minutos = (segundosTotal % 3600) / 60;
            int segundos = (segundosTotal % 3600) % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
