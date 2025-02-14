using System;
using System.Collections.Generic;
namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Fila = new Queue<string>();
            Fila.Enqueue("aviao1");
            Fila.Enqueue("aviao2");
            Fila.Enqueue("aviao3");
            Fila.Enqueue("aviao4");
            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Quantidade de aviões que estão aguardando na fila de decolagem");
                Console.WriteLine("2 - Autorizar a decolagem do primeiro avião da fila de decolagem");
                Console.WriteLine("3 - Adicionar um avião na fila de decolagem");
                Console.WriteLine("4 - Listar todos os aviões que estão na fila de decolagem");
                Console.WriteLine("5 - Exibir o primeiro avião da fila de decolagem");
                Console.WriteLine("6 - Sair");
                int opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 6)
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }
                if (opc == 1)
                {
                    if(Fila.Count == 0)
                        Console.WriteLine("Fila vazia!");
                    else
                    Console.WriteLine("Quantidade de aviões: " + Fila.Count);
                }
                else if (opc == 2)
                {
                    if (Fila.Count == 0)
                        Console.WriteLine("Fila vazia!");
                    else
                    Console.Write("avião decolado: " + Fila.Dequeue());
                }
                else if (opc == 3)
                {
                        Console.WriteLine("Novo avião: ");
                        string novo = Console.ReadLine();
                        Fila.Enqueue(novo);
                        Console.WriteLine("avião adicionado");
                }
                else if (opc == 4)
                {
                    if (Fila.Count == 0)
                        Console.WriteLine("Fila vazia!");
                    else
                    {
                        Queue<string> CopiaFila = new Queue<string>(Fila);
                        while (CopiaFila.Count != 0)
                           Console.WriteLine("aviões: " + CopiaFila.Dequeue());
                    }
                }
                else if (opc == 5)
                {
                    if (Fila.Count == 0)
                        Console.WriteLine("Fila vazia!");
                    else
                        Console.WriteLine("primeiro avião: " + Fila.Peek());
                }
                else
                {
                    Console.WriteLine("Programa finalizado!");   
                    break;
                }
                Console.WriteLine("----------------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}