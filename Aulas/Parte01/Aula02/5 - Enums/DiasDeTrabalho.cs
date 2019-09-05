using System;

namespace Aulas.Parte01.Aula02._5Enums
{
    // Flag attribute
    [Flags]
    enum DiasDeTrabalho
    {
        Seg = 0,
        Ter = 1,
        Qua = 2,
        Qui = 4,
        Sex = 8,
        Sab = 16,
        Dom = 32
    }
}
