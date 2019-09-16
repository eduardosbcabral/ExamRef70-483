using System;

namespace Aulas.Parte02.Aula04
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            // Tipo é definido na compilação
            string s = "Certificação C#";
            // Tipo é definido na compilação (por inferência)
            var v = "Certificação C#";
            // Tipo é definido na compilação
            object o = "Certificação C#";

            Console.WriteLine($"s: {s}");
            Console.WriteLine($"v: {v}");
            Console.WriteLine($"o: {o}");

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Console.WriteLine($"s: {s}");
            Console.WriteLine($"v: {v}");
            Console.WriteLine($"o: {o}");

            //s = 123; (x)
            //v = 123; (x)
            o = 123;
            o = (int)o + 4;
            Console.WriteLine($"o: {o}");

            // Tipo é definido em tempo de execução
            dynamic d = "Certificação C#";
            Console.WriteLine($"d: {d}");
            d = d.ToUpper();
            Console.WriteLine($"d: {d}");
            d = 123;
            Console.WriteLine($"d: {d}");
            d = d + 4;
            Console.WriteLine($"d: {d}");
        }
    }
}
