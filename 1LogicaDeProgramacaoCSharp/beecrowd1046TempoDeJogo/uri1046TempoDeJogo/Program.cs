using System;

namespace uri1046TempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicio, horaFim, tempoMax = 24, calcTempo;

            string[] tempo = Console.ReadLine().Split();
            horaInicio = int.Parse(tempo[0]);
            horaFim = int.Parse(tempo[1]);

            if (horaInicio > horaFim)
            {
                calcTempo = ((tempoMax - horaInicio) + horaFim);
                Console.WriteLine("O JOGO DUROU " + calcTempo + " HORA(S)");
            }
            else if (horaInicio < horaFim)
            {
                calcTempo = horaFim - horaInicio;
                Console.WriteLine("O JOGO DUROU " + calcTempo + " HORA(S)");
            }
            else if (horaInicio == horaFim)
            {
                calcTempo = tempoMax;
                Console.WriteLine("O JOGO DUROU " + calcTempo + " HORA(S)");
            }

        }
    }
}
