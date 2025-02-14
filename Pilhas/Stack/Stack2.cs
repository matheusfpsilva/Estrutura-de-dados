 using System;
using System.Collections.Generic;
namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> pilha = new Stack<char>();
            Console.Write("Informe a sequência: ");
            string sequencia = Console.ReadLine();
            for (int i = 0; i < sequencia.Length; i++)
            {
                char c = sequencia[i];
                if (c == ')' || c == ']')
                {
                    if (pilha.Count == 0 || (c == ')' && pilha.Peek() != '(') || (c == ']' && pilha.Peek() != '['))
                    {
                        return;
                    }
                    pilha.Pop();
                }
                else if (c == '(' || c == '[')
                {
                    pilha.Push(c);
                }
            }
            if (pilha.Count == 0)
            {
                Console.WriteLine("sequência está bem-formada!");
            }
            else
            {
                Console.WriteLine("a sequência está malformada!");
            }
            Console.ReadKey();
        }
    }
}