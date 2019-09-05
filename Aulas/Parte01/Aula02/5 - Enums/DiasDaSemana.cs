namespace Aulas.Parte01.Aula02._5Enums
{
    // Enum quando não é declarado valor, o padrão começa no valor 0
    // Quando recebe valor e o próximo não, o próximo valor recebe a sequência do anterior. Ex: anterior = 15, proximo(recebe 16)
    enum DiasDaSemana : long
    {
        Seg,
        Ter,
        Qua,
        Qui,
        Sex,
        Sab,
        Dom
    }
}
