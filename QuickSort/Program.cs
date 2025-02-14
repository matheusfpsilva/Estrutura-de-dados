using System.Runtime.CompilerServices;

namespace QuickSort
{
    internal class Program
    {
        public static int ParticaoC(int[] vetor, int inicio, int fim)
        {
            int pivot = vetor[fim];
            int part = inicio - 1;
            for(int i = inicio; i < fim; i++)
            {
                if (vetor[i] < pivot)
                {
                    part++;
                    int aux = vetor[part];
                    vetor[part] = vetor[i];
                    vetor[i] = aux;
                }
            }
            int aux2 = vetor[part + 1];
            vetor[part + 1] = vetor[fim];
            vetor[fim] = aux2;
            return part + 1;
        }
        public static void QuickSortC(int[] vetor, int inicio, int fim)
        {
            int part;
            if(inicio < fim)
            {
                part = ParticaoC(vetor, inicio, fim);
                QuickSortC(vetor, inicio, part - 1);
                QuickSortC(vetor, part + 1, fim);
            }
        }
        public static int ParticaoD(int[] vetor, int inicio, int fim)
        {
            int pivot = vetor[fim];
            int part = inicio - 1;
            for (int i = inicio; i < fim; i++)
            {
                if (vetor[i] > pivot)
                {
                    part++;
                    int aux = vetor[part];
                    vetor[part] = vetor[i];
                    vetor[i] = aux;
                }
            }
            int aux2 = vetor[part + 1];
            vetor[part + 1] = vetor[fim];
            vetor[fim] = aux2;
            return part + 1;
        }
        public static void QuickSortD(int[] vetor, int inicio, int fim)
        {
            int part;
            if (inicio < fim)
            {
                part = ParticaoD(vetor, inicio, fim);
                QuickSortD(vetor, inicio, part - 1);
                QuickSortD(vetor, part + 1, fim);
            }
        }
        public static void Imprimir(int[] vetor)
        {
            foreach(int valor in vetor)
            {
                Console.Write(valor  + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1) QuickSort Crescente\n2) QuickSort Decrescente\n");
            int opc = int.Parse(Console.ReadLine());
            if(opc < 1 || opc > 2)
            {
                Console.WriteLine("Opção inválida!");
            }
            else
            {
                Console.WriteLine("Informe o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());
                int[] vetor = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write("Informe o valor para a posição {0}: ", i);
                    int valor = int.Parse(Console.ReadLine());
                    vetor[i] = valor;
                }
                if(opc == 1)
                {
                    Console.WriteLine("Crescente: ");
                    QuickSortC(vetor, 0, tamanho - 1);
                    Imprimir(vetor);
                }
                else
                {
                    Console.WriteLine("Decrescente: ");
                    QuickSortD(vetor, 0, tamanho - 1);
                    Imprimir(vetor);
                }
            }
            Console.ReadKey();
        }
    }
}