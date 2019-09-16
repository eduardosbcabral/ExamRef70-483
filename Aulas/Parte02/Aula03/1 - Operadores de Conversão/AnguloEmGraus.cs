using System;

namespace Aulas.Parte02.Aula03._1Operadores_de_Conversão
{
    struct AnguloEmGraus
    {
        public double Graus { get; }

        public AnguloEmGraus(double graus)
        {
            Graus = graus;
        }

        public static implicit operator AnguloEmGraus(AnguloEmRadianos radianos)
        {
            return new AnguloEmGraus(radianos.Radianos * 180 / Math.PI);
        }

        public static implicit operator AnguloEmGraus(double graus)
        {
            return new AnguloEmGraus(graus);
        }

        public static implicit operator double(AnguloEmGraus graus)
        {
            return graus.Graus;
        }

        public override string ToString()
        {
            return $"{Graus} graus.";
        }
    }
}
