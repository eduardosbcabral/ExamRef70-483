using System;

namespace Aulas.Parte01.Aula04
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            // O método pode ser chamado do jeito normal, usando argumentos posicionais.
            ImprimirDetalhesDoPedido("Maria de Fátima", 31, "Caneca Vermelha");

            // Argumentos nomeados podem ser fornecidos para os parâmetros em qualquer ordem.
            ImprimirDetalhesDoPedido(numeroPedido: 31, nomeProduto: "Caneca Vermelha", vendedor: "Maria de Fátima");
            ImprimirDetalhesDoPedido(nomeProduto: "Caneca Vermelha", vendedor: "Maria de Fátima", numeroPedido: 31);

            // Argumentos nomeados misturados com argumentos posicionais são válidos.
            ImprimirDetalhesDoPedido("Maria de Fátima", 31, nomeProduto: "Caneca Vermelha");

            // As 2 linhas abaixo geraram erro de compilação antes do C# 7.2
            ImprimirDetalhesDoPedido(vendedor: "Maria de Fátima", 31, nomeProduto: "Caneca Vermelha");
            ImprimirDetalhesDoPedido("Maria de Fátima", numeroPedido: 31, "Caneca Vermelha");
        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrEmpty(vendedor))
            {
                throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio", paramName: vendedor);
            }

            Console.WriteLine($"Vendedor: {vendedor}, Pedido No.: {numeroPedido}, Produto: {nomeProduto}");
        }
    }
}
