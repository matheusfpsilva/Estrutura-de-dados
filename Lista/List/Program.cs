using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> Lista = new List<double>();
            while (true)
            {
                Console.WriteLine("1) Inserir um tempo no início da lista\n2) Inserir um tempo no final da lista\n3) Inserir um tempo numa posição específica da lista\n" +
                    "4) Remover o primeiro tempo da lista\n5) Remover o último tempo da lista\n6) Remover um tempo de uma posição específica na lista\n" +
                    "7) Remover um tempo específico da lista\n8) Pesquisar quantas vezes um determinado tempo consta na lista\n9) Mostrar todos os tempos da lista\n" +
                    "10) Encerrar o programa\n ");
                int opc = int.Parse(Console.ReadLine());
                if (opc < 1 || opc > 10)
                {
                    Console.WriteLine("Opcão inválida!");
                    continue;
                }
                if (opc == 1)
                {
                    Console.Write("Informe um tempo: ");
                    double tempo = double.Parse(Console.ReadLine());
                    Lista.Insert(0, tempo);
                    Console.WriteLine("Tempo inserido!");
                }
                else if (opc == 2)
                {
                    Console.Write("Informe um tempo: ");
                    double tempo = double.Parse(Console.ReadLine());
                    Lista.Add(tempo);
                    Console.WriteLine("Tempo inserido!");
                }
                else if (opc == 3)
                {
                    Console.Write("Informe um tempo: ");
                    double tempo = double.Parse(Console.ReadLine());
                    Console.Write("Informe a posição para adicioná-lo: ");
                    int posicao = int.Parse(Console.ReadLine());
                    if(posicao >= 0 && posicao <= Lista.Count)
                    {
                        Lista.Insert(posicao, tempo);
                        Console.WriteLine("Tempo inserido!");
                    }
                    else
                        Console.WriteLine("Posição inválida!");
                }
                else if (opc == 4)
                {
                    double removido = 0;
                    if (Lista.Count != 0)
                    {
                        removido = Lista[0];
                        Lista.RemoveAt(0);
                        Console.WriteLine("Tempo removido: " + removido);
                    }
                    else
                        Console.WriteLine("Lista vazia!");
                }
                else if (opc == 5)
                {
                    double removido = 0;
                    if (Lista.Count != 0)
                    {
                        removido = Lista[Lista.Count - 1];
                        Lista.RemoveAt(Lista.Count-1);
                        Console.WriteLine("Tempo removido: " + removido);
                    }                        
                    else
                        Console.WriteLine("Lista vazia!");
                }
                else if (opc == 6)
                {
                    double removido = 0;
                    Console.Write("Informe a posição para retirar um tempo: ");
                    int posicao = int.Parse(Console.ReadLine());
                    if (posicao >=0 && posicao < Lista.Count)
                    {
                        removido = Lista[posicao];
                        Lista.RemoveAt(posicao);
                        Console.WriteLine("Tempo removido: " + removido);
                    }         
                    else
                        Console.WriteLine("posição inválida!");
                }
                else if (opc == 7)
                {
                    Console.Write("Informe um tempo para ser retirado: ");
                    double tempo = double.Parse(Console.ReadLine());
                    if (Lista.Contains(tempo))
                    {
                        Lista.Remove(tempo);
                        Console.WriteLine("Tempo removido!");
                    }
                    else
                        Console.WriteLine("tempo inválido!");
                }
                else if (opc == 8)
                {
                    Console.Write("Informe um tempo: ");
                    double tempo = double.Parse(Console.ReadLine());
                    int cont = 0;
                    if(Lista.Count == 0)
                        Console.WriteLine("Lista vazia!");
                    else
                    {
                        for(int i = 0; i < Lista.Count; i++)
                        {
                            if (Lista[i] == tempo)
                                cont++;
                        }
                        Console.WriteLine("Consta na lista {0} vezes ", cont);
                    }
                }
                else if (opc == 9)
                {
                    if(Lista.Count == 0)
                        Console.WriteLine("Lista vazia");
                    else
                    {
                        Console.WriteLine("Tempos : ");
                        for(int i = 0;i < Lista.Count; i++)
                        {
                            Console.WriteLine("Posição " + i + ": ");
                            Console.WriteLine(Lista[i]);
                        }
                    }
                }
                else
                {
                    Console.Write("Programa encerrado!");
                    break;
                }
                Console.WriteLine("--------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
