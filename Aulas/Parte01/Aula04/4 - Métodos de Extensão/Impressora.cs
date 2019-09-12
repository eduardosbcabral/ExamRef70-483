using System;
namespace Aulas.Parte01.Aula04._4Métodos_de_Extensão
{
    class Impressora
    {
        public string Documento { get; set; }

        public Impressora(string documento)
        {
            Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }

        //public void ImprimirDocumentoHTML()
        //{
        //    Console.WriteLine($"<html><body>{Documento}</body></html>");
        //}
    }
}
