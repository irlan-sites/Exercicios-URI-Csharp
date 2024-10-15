namespace ConversaoTempoEx004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundosTotal;

            segundosTotal = int.Parse(Console.ReadLine());
            string[] horasConversao = ((double) segundosTotal / 3600.0).ToString().Split('.');
            int horas = int.Parse(horasConversao[0]);

            string[] minutosConversao = (double.Parse($"0,{horasConversao[1]}") * 60).ToString().Split('.');
            int minutos = int.Parse(minutosConversao[0]);

            int segundos = Convert.ToInt32(double.Parse($"0,{minutosConversao[1]}") * 60);

            Console.WriteLine($"{horas}h{minutos}min{segundos}s");
            
        }
    }
}