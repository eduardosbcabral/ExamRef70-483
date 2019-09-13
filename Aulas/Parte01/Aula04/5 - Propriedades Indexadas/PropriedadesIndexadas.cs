using Aulas.Parte01.Aula04._5Propriedades_Indexadas;
using System;

namespace Aulas.Parte01.Aula04
{
    class PropriedadesIndexadas : IAulaItem
    {
        public void Executar()
        {
            var sala = new Sala();
            sala["D01"] = new ClienteCinema("Maria de Souza");
            sala["D02"] = new ClienteCinema("José da Silva");
            Console.WriteLine(sala["D01"]);
            sala.ImprimirReservas();
        }
    }
}
