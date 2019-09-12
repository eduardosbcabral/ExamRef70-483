namespace Aulas.Parte01.Aula04._1Métodos
{
    class Retangulo
    {

        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            System.Console.WriteLine($"altura: {altura}, largura: {largura}");

            var area = GetArea();
            System.Console.WriteLine($"area: {area  }");
        }

        //public, internal, protected (+internal), private (+internal)

        internal double GetArea()
        {
            return Altura * Largura;
        }

        internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetanguloLargura / outroRetanguloAltura)) /*proporção outro retãngulo*/
                ||
                ((Altura / Largura) == /*Compara a proporção inversa*/
                (outroRetanguloLargura / outroRetanguloAltura));
        }

        internal bool Semelhante(Retangulo retangulo)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (retangulo.Largura / retangulo.Altura)) /*proporção outro retãngulo*/
                ||
                ((Altura / Largura) == /*Compara a proporção inversa*/
                (retangulo.Largura / retangulo.Altura));
        }

        internal static bool Semelhante(Retangulo retangulo, Retangulo outroRetangulo)
        {
            return
                ((retangulo.Largura / retangulo.Altura) == /*proporção deste retângulo*/
                (outroRetangulo.Largura / outroRetangulo.Altura)) /*proporção outro retãngulo*/
                ||
                ((retangulo.Altura / retangulo.Largura) == /*Compara a proporção inversa*/
                (outroRetangulo.Largura / outroRetangulo.Altura));
        }
    }
}
