using System;

namespace Aulas.Parte01.Aula02
{
    public class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            // idade = 15.5; Dá erro pois o compilador não entende que 15.5 é um número flutuante
            idade = 15.5f; // É necessário colocar o sufixo f para o compilador entender

            //int mes = 6_00000_000000_000000_000000; (x)
            //long massa = 6_00000_000000_000000_000000; (x)
            //long massa = 6e24; (x) 6e24 = outra forma de se representar o valor acima
            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");

            float massaDaTerra = 5.9736e24f; // System.Single
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");

            Console.WriteLine($"float.MinValue: {float.MinValue}");
            Console.WriteLine($"float.MaxValue: {float.MaxValue}");

            float numeroPI = 3.14159f; // System.Single
            Console.WriteLine($"numeroPI: {numeroPI}");

            //float numeroMuitoMaior = 6e100; Ultrapassa o limite de float
            double numeroMuitoMaior = 6e100; // System.Double

            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            short y = 5;

            var resultado1 = x * y;
            Console.WriteLine("x * y = {0}", resultado1);
            Console.WriteLine($"O resultado1 é do tipo: {resultado1.GetType()}");

            float z = 4.5f;

            var resultado2 = x * y / z;
            Console.WriteLine("x * y / z: {0}", resultado2);
            Console.WriteLine($"O resultado2 é do tipo: {resultado2.GetType()}");

            //C#        .NET            Faixa de Valores        Precisão
            //===============================================================
            //float     System.Single   ±1.5e-45 to ±3.4e38     7 digitos
            //double    System.Double   ±5.0e-324 to ±1.7e308   15-16 dígitos

        }
    }
}
