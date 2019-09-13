using Aulas.Parte01.Aula05._2Métodos_Substituídos;

namespace Aulas.Parte01.Aula05
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            Animal gato = new Gato() { Nome = "Bichano" };
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gata = new Gato() { Nome = "Pantera" };
            gata.Beber();
            gata.Comer();
            gata.Andar();
        }
    }
}
