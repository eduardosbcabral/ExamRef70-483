using System;

namespace Aulas.Parte01.Aula02
{
    public class Booleanos : IAulaItem
    {
        public void Executar()
        {
            //bool possuiSaldo = 1; (x)
            bool possuiSaldo = true;

            Console.WriteLine($"possuiSaldo: {possuiSaldo}");

            int dias = DateTime.Now.Day;
            Console.WriteLine($"dias: {dias}");

            // Atribuir a diasPar o valor de uma expressão booleana
            bool diasPar = (dias % 2 == 0);
            Console.WriteLine($"diasPar: {diasPar}");

            if(diasPar)
            {
                Console.WriteLine("dias é um número par");
            }
            else
            {
                Console.WriteLine("dias é um número ímpar");
            }
        }
    }
}
