using Aulas.Parte01.Aula05._2Métodos_Substituídos;
using System;

namespace Aulas.Parte02.Aula02
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double divida = 1_234_567_890.123;
            //long copia = divida; (x)

            double salario = 1_237.89;
            long copiaSalario = (long)salario;
            Console.WriteLine($"copiaSalario: {copiaSalario}");

            Animal animal = new Gato();
            Gato gato = (Gato)animal; // cast = conversão explícita
            Console.WriteLine($"gato: {gato.GetType()}");
        }
    }
}
