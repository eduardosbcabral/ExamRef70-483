using System;

namespace Aulas.Parte02.Aula04
{
    class ResolucaoDeSobrecarga : IAulaItem
    {
        public void Executar()
        {
            int int1 = 123;
            int int2 = 456;

            short short1 = 123;
            short short2 = 456;

            double double1 = 123.45;
            double double2 = 456.78;

            Console.WriteLine($"Somar(int1, int2): {Somar(int1, int2)}");
            Console.WriteLine($"Somar(short1, short2): {Somar(short1, short2)}");
            Console.WriteLine($"Somar(double1, double2): {Somar(double1, double2)}");
            Console.WriteLine($"Somar(abc, xyz): {Somar("abc", "xyz")}");
        }

        int Somar(int parcela1, int parcela2)
        {
            return parcela1 + parcela2;
        }

        short Somar(short parcela1, short parcela2)
        {
            return (short)(parcela1 + parcela2);
        }

        // comentado, pois o compilador não consegue diferenciar 
        // o método que recebe dynamic e o método que recebe object
        //double Somar(object parcela1, object parcela2)
        //{
        //    return (double)parcela1 + (double)parcela2;
        //}

        dynamic Somar(dynamic parcela1, dynamic parcela2)
        {
            return parcela1 + parcela2;
        }
    }
}
