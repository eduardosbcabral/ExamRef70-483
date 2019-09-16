using Aulas.Parte02.Aula03._1Operadores_de_Conversão;
using System;

namespace Aulas.Parte02.Aula03
{
    class OperadoresDeConversao : IAulaItem
    {
        public void Executar()
        {
            AnguloEmGraus anguloEmGraus = 45;
            Console.WriteLine($"anguloEmGraus: {anguloEmGraus}");

            AnguloEmRadianos anguloEmRadianos = 15;
            Console.WriteLine($"anguloEmRadianos: {anguloEmRadianos}");

            double graus = anguloEmGraus;
            Console.WriteLine($"graus: {graus}");

            anguloEmRadianos = (AnguloEmRadianos)anguloEmGraus; // Operador Explícito 
            anguloEmGraus = anguloEmRadianos; // Operador Implícito
            Console.WriteLine($"anguloEmGraus: {anguloEmGraus}");
            Console.WriteLine($"anguloEmRadianos: {anguloEmRadianos}");
        }
    }
}
