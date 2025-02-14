namespace Recursividade
{
    internal class Program 
    {
        static int Calcula(int a, int n)
        {
            if (n == 0)
                return 1;
            else if (a < 0 || n < 0)
                return -1;
            else
                return a * Calcula(a, n-1);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de n: ");
            int n = int.Parse(Console.ReadLine());
            int resultado = Calcula(a, n);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}