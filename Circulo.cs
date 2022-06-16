namespace Exercicio1_POO
{
    public class Circulo : Forma
    {
        private int Raio;

        public Circulo(int raio)
        {
            Raio = raio;
        }

        public override void CalcularDimensao()
        {
            Console.WriteLine("A área do círculo é: " + ((Raio * Raio) * 3.14));
        }
    }
}
