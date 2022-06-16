namespace Exercicio1_POO
{
    public class Quadrado : Forma
    {
        private int Largura;
        private int Altura;

        public Quadrado(int largura, int altura)
        {
            Largura = largura;
            Altura = altura;
        }         
        public override void CalcularDimensao()
        {
            Console.WriteLine("A área do quadrado é: " + Largura * Altura);
        }  
    }
}
