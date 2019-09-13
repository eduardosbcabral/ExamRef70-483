using System;

namespace Aulas.Parte01.Aula05._2Métodos_Substituídos
{
    class Animal : IAnimal
    {
        public string Nome { get; set; }

        public void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }

        public virtual void Comer()
        {
            Console.WriteLine("Animal.Comer");
        }

        public void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }
    }
}
