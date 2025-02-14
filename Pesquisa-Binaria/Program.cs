namespace Pesquisa-binaria
{
    internal class Program
    {
        static int pesquisaBinaria(int[] vetor, int item, int inicio, int fim)
        {
            if (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                if (vetor[meio] == item)
                    return meio;
                if (vetor[meio] > item)
                    return pesquisaBinaria(vetor, item, inicio, meio - 1);
                else
                    return pesquisaBinaria(vetor, item, meio + 1, fim);
            }
            else return -1;
        }
        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Posição do elemento procurado: " + pesquisaBinaria(vetor, 3, 0, vetor.Length - 1));
            Console.ReadKey();
        }
    }
}