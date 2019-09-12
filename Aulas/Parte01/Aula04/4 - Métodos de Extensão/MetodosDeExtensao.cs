using Aulas.Parte01.Aula04._4Métodos_de_Extensão;
using System;

namespace Aulas.Parte01.Aula04
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Este é\r\no meu documento");
            impressora.ImprimirDocumento();
            impressora.ImprimirDocumentoHTML();
        }
    }
}
