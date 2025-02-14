namespace Recursividade
{
    internal class Program
    {
        static int Soma(int m, int n)
        {
            if (n < m)
                return 0;
            else
                return m + Soma(m + 1, n);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de n: ");
            int n = int.Parse(Console.ReadLine());
            int resultado = Soma(m, n);
            Console.Write(resultado);
            Console.ReadKey();

        }
    }
}