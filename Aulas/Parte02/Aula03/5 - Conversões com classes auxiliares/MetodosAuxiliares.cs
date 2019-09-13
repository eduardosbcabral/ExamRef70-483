using System;
using System.Globalization;

namespace Aulas.Parte02.Aula03
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";
            //int numeroConvertido = textoDigitado; (x)
            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine($"numeroConvertido: {numeroConvertido}");

            textoDigitado = "ABC";
            //numeroConvertido = int.Parse(textoDigitado); (x)
            if (int.TryParse(textoDigitado, out numeroConvertido))
            {
                Console.WriteLine($"numeroConvertido: {numeroConvertido}");
            }
            else
            {
                Console.WriteLine("Texto não é um número.");
            }

            // Quando tiver algum tipo de símbolo (cifrão, etc)
            // é necessário colocar o tipo e cultura
            textoDigitado = "R$ 123,45";
            decimal.TryParse(textoDigitado, 
                NumberStyles.Currency, // Moeda
                CultureInfo.CurrentCulture,
                out decimal valorConvertido);
            Console.WriteLine($"valorConvertido: {valorConvertido}");
        }
    }
}
