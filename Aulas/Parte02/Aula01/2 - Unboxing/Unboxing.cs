using System;

namespace Aulas.Parte02.Aula01
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57; // tipo de valor
            object caixa = numero;  // boxing

            try
            {
                int unboxed = (int)caixa;
                Console.WriteLine("Unboxing OK");
            }catch(InvalidCastException ex)
            {
                Console.WriteLine("{0} Erro: unboxing incorreto.", ex);
            }
        }
    }
}
