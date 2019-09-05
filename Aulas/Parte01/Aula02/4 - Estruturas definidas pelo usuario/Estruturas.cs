using Aulas.Parte01.Aula02._4Estruturas;
using System;

namespace Aulas.Parte01.Aula02
{
    public class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double latitude1 = 13.78;
            double longitude1 = 29.51;
            double latitude2 = 40.23;
            double longitude2 = 17.4;
            Console.WriteLine($"latitude1 = {latitude1}");
            Console.WriteLine($"longitude1 = {longitude1}");
            Console.WriteLine($"latitude2 = {latitude2}");
            Console.WriteLine($"longitude2 = {longitude2}");

            PosicaoGPS posicao1;
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;

            PosicaoGPS posicao2 = new PosicaoGPS()
            {
                Latitude = 40.23,
                Longitude = 17.4
            };

            PosicaoGPS posicao3 = new PosicaoGPS(40.23, 17.4);

            Console.WriteLine(posicao1);
        }
    }
}
