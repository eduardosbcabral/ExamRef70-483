using Aulas.Parte01.Aula03._3Interfaces;

namespace Aulas.Parte01.Aula03
{
    class Interfaces : IAulaItem

    {
        public void Executar()
        {
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();

            eletro1 = new Abajur();
        }
    }
}
