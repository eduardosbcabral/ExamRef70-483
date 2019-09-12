using System;

namespace Aulas.Parte01.Aula04._3Parâmetros_Opcionais
{
    class ClienteEspecial
    {
        private readonly string nome;

        public ClienteEspecial(string nome = "Anônimo")
        {
            this.nome = nome;
        }

        // O primeiro parâmetro é obrigatório e não tem nenhum valor padrão associado a ele.
        // Portanto, ele não é opcional. Tanto endereço quanto quantidade tem valores padrão
        // associados. Eles são opcionais.
        // Colocar todos os opcionais por último na lista de parâmetros.
        public void FazerPedido(int produtoId, string endereco = "Residencial", int quantidade = 10)
        {
            Console.WriteLine("cliente: {0}, produtoId: {1}, endereco: {2}, quantidade: {3}", nome, produtoId, endereco, quantidade);
        }
    }
}
