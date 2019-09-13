using System;

namespace Aulas.Parte01.Aula03
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            string a = "bom dia";
            string b = "b";

            // Quando são declaradas duas variáveis com o mesmo valor,
            // a CLR do .NET otimiza apontando as duas para o mesmo endereço de memória.
            string variavel1 = "C";
            string variavel2 = "C";

            // Adiciona ao conteúdo de "b"
            b = b + "om dia";
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"(object)a == (object)b: {(object)a == (object)b}");

            string bomDia = "bom dia";
            Console.WriteLine($"bomDia[4]: {bomDia[4]}");

            var caractere = bomDia[4];
            Console.WriteLine($"caractere.GetType(): {caractere.GetType()}"); // System.Char
        }
    }
}
