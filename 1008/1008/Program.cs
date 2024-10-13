using System.Globalization;
namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numFuncionario, horasTrabalhadas;
            double dinheiroPorHora;

            numFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            dinheiroPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.WriteLine($"SALARY = U$ {(horasTrabalhadas * dinheiroPorHora).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
