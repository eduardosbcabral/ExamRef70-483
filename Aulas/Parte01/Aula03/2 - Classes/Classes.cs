using Aulas.Parte01.Aula03._2Classes;
using System;

namespace Aulas.Parte01.Aula03
{
    public class Classes : IAulaItem
    {
        public void Executar()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS()
            {
                Latitude = 13.78,
                Longitude = 29.51
            };

            posicao1 = new ClassePosicaoGPS(13.78, 29.51);

            Console.WriteLine($"posicao1: {posicao1}");

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(13.78, 29.51, DateTime.Now);

            Console.WriteLine($"posicao2: {posicao2}");
        }
    }
}
