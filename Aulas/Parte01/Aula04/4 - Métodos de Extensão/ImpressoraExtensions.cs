using System;

namespace Aulas.Parte01.Aula04._4Métodos_de_Extensão
{
    static class ImpressoraExtensions
    {
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    }
}
