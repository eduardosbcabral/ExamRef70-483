using Aulas.Parte01.Aula04._1Métodos;
using System;

namespace Aulas.Parte01.Aula04
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);
            Console.WriteLine(retangulo.GetArea());

            Retangulo outroRetangulo = new Retangulo(10, 10);
            Console.WriteLine(retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura));

            outroRetangulo = new Retangulo(5, 6);
            Console.WriteLine(retangulo.Semelhante(outroRetangulo));

            Console.WriteLine(Retangulo.Semelhante(retangulo, outroRetangulo));
        }
    }
}
