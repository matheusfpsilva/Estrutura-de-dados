namespace Recursividade
{
    internal class Program
    {
        static int MDC(int x, int y)
        {
            if (x == y)
                return x;
            else if(x > y)
                return MDC(x-y, y);
            else
                return MDC(x, y - x);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write(MDC(x, y));
            Console.ReadKey();
        }
    }
}