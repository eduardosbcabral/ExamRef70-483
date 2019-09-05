using System;

namespace Aulas.Parte01.Aula01
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5; (X)

            char resposta = 'S'; // System.Char

            byte nivelDeAzul = 0xFF; // System.Byte | = 255 em decimal
            //nivelDeAzul = -3; (X)

            short passageirosVoo = 230; // System.Int16
            //passageirosVoo = -7; (V)

            int populacao = 1500; // System.Int32
            //populacao = -2300; (V)

            long populacaoDoBrasil = 207_660_929; // System.Int64 | +/- 207 milhões

            sbyte nivelDeBrilho = -127; // System.Sbyte

            ushort passageirosNavio = 230; // System.UInt16 | u = unsigned

            uint estoque = 1500; // System.UInt34 | u = unsigned

            ulong populacaoDoMundo = 7_000_000_000; // System.UInt64 | u = unsigned

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");

            // Erros
            //nivelDeAzul = 0xFFFF; // = 65535 em decimal
            //passageirosVoo = 230000; // System.Int16
            //populacao = 1500000000000; // System.Int32
            //passageirosNavio = -15; // System.UInt16
            //estoque = -2300; // System.UInt32
            //populacaoDoBrasil = 207_660_292.345; // System.Int64 | casa decimal

            // Tipo     Faixa de Valores                        Tamanho
            //==============================================================================
            //sbyte     -128 to 127                             Com sinal 8-bit integer
            //byte      0 to 255                                Sem sinal 8-bit integer
            //char      U+000 to U+ffff                         Unicode 16-bit character
            //short     -32,768 to 32,767                       Com sinal 16-bit integer
            //ushort    0 to 65,535                             Sem sinal 16-bit integer
            //int       -2,147,483,648 to 2,147,483,647         Com sinal 32-bit integer
            //uint      0 to 4,294,967,295                      Sem sinal 32-bit integer
            //long      -9,223,372,036,854,775,808 to
            //          9,223,372,036,854,775,807               Com sinal 64-bit integer
            //ulong     0 to 18,446,744,073,709,551,615         Sem sinal 64-bit integer
        }
    }
}
