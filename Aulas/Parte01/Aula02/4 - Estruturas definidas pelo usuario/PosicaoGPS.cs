using System;

namespace Aulas.Parte01.Aula02._4Estruturas
{
    // Uma das diferenças entre classe e structs é que uma variável struct é um tipo de valor e não um tipo de referência,
    // ou seja quando copiamos uma struct para outra, ambas as variáveis ficam independentes, uma alteração não reflete na outra struct.
    // Ideal para representar uma classe muito leve, ou seja, com poucos dados e que seja muito simples. Por exemplo: Ponto, Cor.
    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        //public PosicaoGPS() Structs não podem ter construtores sem parâmetro
        //{
        //}

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude} - Longitude: {Longitude}";
        }
    }
}
