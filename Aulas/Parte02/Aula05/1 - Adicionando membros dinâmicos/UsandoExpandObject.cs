using Aulas.Parte02.Aula05._1Adicionando_membros_dinâmicos;
using Newtonsoft.Json;
using System;
using System.Dynamic;

namespace Aulas.Parte02.Aula05
{
    class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\", " +
                "\"Para\": \"Guilherme Silveira\"}";

            //var mensagem = JsonConvert.DeserializeObject<Mensagem>(json);
            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);

            // Para acessar as propriedades é necessário "tipar" o objeto
            // como dynamic
            mensagem.Texto = "Olá, " + mensagem.Para;

            EnviarMensagem(mensagem);

            mensagem.Inverter = new Action(() =>
            {
                var aux = mensagem.De;
                mensagem.De = mensagem.Para;
                mensagem.Para = aux;
                mensagem.Texto = "Olá, " + mensagem.Para;
            });

            mensagem.Inverter();
            EnviarMensagem(mensagem);
        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }
}
