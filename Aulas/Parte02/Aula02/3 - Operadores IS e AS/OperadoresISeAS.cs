using Aulas.Parte01.Aula03._1TiposDeReferencia;
using Aulas.Parte01.Aula05._2Métodos_Substituídos;
using System;

namespace Aulas.Parte02.Aula02
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);

            float valor = 123.45f;
            var resultado = valor is int;
            Console.WriteLine($"resultado: {resultado}");
        }

        public void Alimentar(object obj)
        {
            //Animal animal = null;
            //if(obj is Animal)
            //{
            //    animal = (Animal)obj;
            //} (1)

            //Animal animal = obj as Animal; (2)


            //if (animal == null)
            //{
            //    Console.WriteLine("obj não é um animal");
            //    return;
            //}

            if(obj is Animal animal)
            {
                animal.Beber();
                animal.Comer();
                return;
            }

            Console.WriteLine("obj não é um animal");
        }
    }
}
