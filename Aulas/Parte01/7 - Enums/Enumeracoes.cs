using Aulas.Parte01._7Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aulas.Parte01
{
    public class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            const int Seg = 0;
            const int Ter = 1;
            const int Qua = 2;

            DiasDaSemana primeiroDia = DiasDaSemana.Dom;

            DiasDeTrabalho diasDeTrabalho = DiasDeTrabalho.Ter | DiasDeTrabalho.Qui | DiasDeTrabalho.Sex | DiasDeTrabalho.Seg;
            // Operador | (Pipe) selecionar múltiplos valores do enum. Se o enum não tiver Flag Attribute, irá somar os valores
            // Se o valor de um enum for 0, não irá ser impresso no console
            Console.WriteLine(diasDeTrabalho);
        }
    }
}
