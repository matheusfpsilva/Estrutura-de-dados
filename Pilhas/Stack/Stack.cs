using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<double> pilha = new Stack<double>();
            Console.Write("Informe a expressão: ");
            string expressao = Console.ReadLine();
            double res = 0;
            for (int i = 0; i < expressao.Length; i++)
            {
                if (expressao[i]!='+' && expressao[i] != '-' && expressao[i] != '*' && expressao[i] != '/')
                {
                    int numeros = (int)char.GetNumericValue(expressao[i]);
                    pilha.Push(numeros);       
                }
                else
                {
                    char operador = expressao[i];
                    double num1 = pilha.Pop();
                    double num2 = pilha.Pop();
                    if (operador == '+')
                    {
                        res = num1 + num2;
                    }
                    else if (operador == '-')
                    {
                        res = num2 - num1;
                    }
                    else if (operador == '*')
                    {
                        res = num1 * num2;
                    }
                    else if (operador == '/')
                    {
                        if(num1 == 0)
                        {
                            Console.WriteLine("erro");    
                        }
                        res = num2 / num1;
                    }
                    pilha.Push(res);
                }
            }
            double resultado = pilha.Pop();
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
