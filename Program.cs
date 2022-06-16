namespace Exercicio1_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(5, 8); 
            quadrado.CalcularDimensao();

            Circulo circulo = new Circulo(15);
            circulo.CalcularDimensao();
        }
    }
}