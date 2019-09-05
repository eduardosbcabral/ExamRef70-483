using System;

namespace Aulas.Parte01.Aula03
{
    // A existência dos membros de um objeto dynamic são verificados somente em tempo de execução.
    // Operações que contêm expressões dynamic não são resolvidas ou verificadas pelo compilador.
    // O tipo dynamic existe somente em tempo de compilação e não em tempo de execução.
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto = objeto + 3; (x)

            dynamic dinamico = 1;
            dinamico = dinamico + 3;
            Console.WriteLine(dinamico);

            //dinamico.teste(); (x)
        }
    }
}
