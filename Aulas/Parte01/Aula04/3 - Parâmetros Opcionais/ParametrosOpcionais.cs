using Aulas.Parte01.Aula04._3Parâmetros_Opcionais;

namespace Aulas.Parte01.Aula04
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas Skywalker");
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);
            clienteEspecial.FazerPedido(2, "Comercial");
            clienteEspecial.FazerPedido(3);

            // As instruções a seguir produzem erros de compilação.
            // Um argumento tem que ser fornecido para o primeiro parâmetro e ele
            // precisa ser um inteiro.
            //clienteEspecial.FazerPedido("Residencial", 1);
            //clienteEspecial.FazerPedido();

            // Você não pode deixar um "buraco" nos argumentos
            //clienteEspecial.FazerPedido(3, , 4);
            //clienteEspecial.FazerPedido(3, 4);

            // Você pode usar um argument nomeado para fazer
            // a instrução anterior funcionar.
            clienteEspecial.FazerPedido(3, quantidade: 4);
        }
    }
}
