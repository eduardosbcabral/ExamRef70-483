using System;
namespace Aulas.Parte02.Aula01
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;
            // nesta linha, número está sofrendo boxing
            object caixa = numero;
            Console.WriteLine(string.Concat("Resposta", numero, true));
        }
    }
}
