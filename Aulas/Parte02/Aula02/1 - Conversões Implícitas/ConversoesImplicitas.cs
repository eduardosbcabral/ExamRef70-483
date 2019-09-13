using Aulas.Parte01.Aula05._2Métodos_Substituídos;
using System;

namespace Aulas.Parte02.Aula02
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;
            Console.WriteLine($"inteiroLongo: {inteiroLongo}");

            //inteiro = inteiroLongo; (x)

            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine($"animal: {animal.GetType()}");
            IAnimal ianimal = gato;
            Console.WriteLine($"ianimal: {ianimal.GetType()}");
            //gato = ianimal; (x)
        }
    }
}

//TABELA DE CONVERSÕES NÚMERICAS IMPLÍCITAS
//=========================================
//De        Para
//=============================================================
//sbyte     short, int, long, float, double ou decimal
//byte      short, ushort, int, uint, long, ulong, float, double ou decimal
//short     int, long, float, double ou decimal
//ushort    int, uint, long, ulong, float, double ou decimal
//int       long, float, double ou decimal
//uint      long, ulong, float, double ou decimal
//long      float, double ou decimal
//char      ushort, int, uint, long, ulong, float, double ou decimal
//float     double
//ulong     float, double ou decimal
//double    (nenhum)
//decimal   (nenhum)
