namespace Aulas.Parte01.Aula04._5Propriedades_Indexadas
{
    class ClienteCinema
    {
        public string Nome { get; set; }

        public ClienteCinema(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
