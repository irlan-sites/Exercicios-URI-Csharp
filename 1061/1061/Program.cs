namespace _1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] diaInicioVet;
            string[] horarioInicioVet;
            string[] diaFinalVet;
            string[] horarioFinalVet;

            diaInicioVet = Console.ReadLine().Split(' ');
            int diaInicio = int.Parse(diaInicioVet[1]);

            horarioInicioVet = Console.ReadLine().Split(':');
            int horaInicio = int.Parse(horarioInicioVet[0]);
            int minutoInicio = int.Parse(horarioInicioVet[1]);
            int segundoInicio = int.Parse(horarioInicioVet[2]);

            diaFinalVet = Console.ReadLine().Split(' ');
            int diaFinal = int.Parse(diaFinalVet[1]);

            horarioFinalVet = Console.ReadLine().Split(':');
            int horaFinal = int.Parse(horarioFinalVet[0]);
            int minutoFinal = int.Parse(horarioFinalVet[1]);
            int segundoFinal = int.Parse(horarioFinalVet[2]);

            int segundosTotalInicio = segundoInicio + (minutoInicio * 60) + (horaInicio * 3600) + (diaInicio * 86400);
            int segundosTotalFinal = segundoFinal + (minutoFinal * 60) + (horaFinal * 3600) + (diaFinal * 86400);
            int segundosTotal = segundosTotalFinal - segundosTotalInicio;

            int conversaoDias = segundosTotal / 86400;
            Console.WriteLine($"{conversaoDias} dia(s)");
            int restoDias = segundosTotal % 86400;
            int conversaoHoras = restoDias / 3600;
            Console.WriteLine($"{conversaoHoras} hora(s)");
            int restoHoras = restoDias % 3600;
            int conversaoMinutos = restoHoras / 60;
            Console.WriteLine($"{conversaoMinutos} minuto(s)");
            int restoMinutos = restoHoras % 60;
            Console.WriteLine($"{restoMinutos} segundo(s)");
        }
    }
}
