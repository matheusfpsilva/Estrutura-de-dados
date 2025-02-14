namespace Recursividade
{
    internal class Program
    {
        static void ParaBinario(double numero)
        {
            if (numero < 1)
                return;
            else
            {
                ParaBinario(numero / 2);
                int divisao = (int)(numero % 2);
                Console.Write(divisao);
            }
        }
        static void Main(string[] args)
        { 
            Console.Write("Digite um número decimal: ");
            double numero = double.Parse(Console.ReadLine());
            Console.Write("Em binário: ");
            ParaBinario(numero); 
            Console.ReadKey();
        }
    }
}