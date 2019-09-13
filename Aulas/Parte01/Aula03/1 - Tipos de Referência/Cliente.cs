using System;

namespace Aulas.Parte01.Aula03._1TiposDeReferencia
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}
