using Aulas.Parte01.Aula03._4Delegates;

namespace Aulas.Parte01.Aula03
{
    // Delegate: representa um método qualquer
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }
}
