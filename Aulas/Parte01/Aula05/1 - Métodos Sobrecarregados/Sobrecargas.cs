using System;

namespace Aulas.Parte01.Aula05
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            // Volume do cubo = lado ^ 3
            int lado = 3;
            Console.WriteLine("VolumeDoCubo: " + Volume(lado));

            // Volume do cilindro = altura * PI * raio ^ 2
            double raio = 2;
            int altura = 10;
            Console.WriteLine("VolumeDoCilindro: " + Volume(altura, raio));

            // Volume do prisma = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine("VolumeDoPrisma: " + Volume(largura, profundidade, altura));
        }

        double Volume(int lado)
        {
            return Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double Volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}
