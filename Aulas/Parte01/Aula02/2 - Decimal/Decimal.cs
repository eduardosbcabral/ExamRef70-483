using System;

namespace Aulas.Parte01.Aula02
{
    public class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double subtotal = 30;

            Console.WriteLine("Descobrindo se (10 + 20) == 30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal); // True

            valorProduto1 = 10.10;
            valorProduto2 = 20.20;
            subtotal = 30.30;

            Console.WriteLine("Descobrindo se (10.10 + 20.20) == 30.30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal); // False

            Console.WriteLine(valorProduto1 + valorProduto2); // 30,3

            Console.WriteLine("Descobrindo se (10.10 + 20.20) == 30.299999999999997");
            Console.WriteLine((valorProduto1 + valorProduto2) == 30.299999999999997); // True

            decimal materiaPrima = 10.1m; // Sufixo m ou M para transformar o número que é normalmente ponto flutuante para decimal
            decimal maoDeObra = 20.2m;
            decimal custo = 30.3m;

            Console.WriteLine("Descobrindo se (10.1m + 20.2m) == 30.3m");
            Console.WriteLine((materiaPrima + maoDeObra) == custo);

            //Tipo C#       : decimal
            //Tipo .NET     : System.Decimal
            //Precisão      : (-7.9 x 10^28 a 7.9 x 10^28)
            //                28-29 dígitos
        }
    }
}