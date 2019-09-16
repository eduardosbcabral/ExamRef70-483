using System;
using System.Collections.Generic;

namespace Aulas.Parte02.Aula04
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            dynamic d1 = 7;
            dynamic d2 = "essa é uma string qualquer";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>() { 123, 456, 789 };

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d3: {d3}");
            Console.WriteLine($"d4: {d4}");

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            IList<int> lista = d4;

            Console.WriteLine($"i: {i}");
            Console.WriteLine($"str: {str}");
            Console.WriteLine($"dt: {dt}");
            Console.WriteLine($"lista: {lista}");

            //int inteiro = d2; (x)
        }
    }
}
