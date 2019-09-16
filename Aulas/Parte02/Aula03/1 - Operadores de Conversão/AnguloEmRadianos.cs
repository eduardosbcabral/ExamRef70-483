using System;
using System.Collections.Generic;
using System.Text;

namespace Aulas.Parte02.Aula03._1Operadores_de_Conversão
{
    struct AnguloEmRadianos
    {
        public double Radianos { get; }

        public AnguloEmRadianos(double radianos)
        {
            Radianos = radianos;
        }

        public static explicit operator AnguloEmRadianos(AnguloEmGraus graus)
        {
            return new AnguloEmRadianos(graus.Graus * Math.PI / 180);
        }

        public static implicit operator AnguloEmRadianos(double radianos)
        {
            return new AnguloEmRadianos(radianos);
        }

        public static implicit operator double(AnguloEmRadianos radianos)
        {
            return radianos.Radianos;
        }

        public override string ToString()
        {
            return $"{Radianos} radianos.";
        }
    }
}
