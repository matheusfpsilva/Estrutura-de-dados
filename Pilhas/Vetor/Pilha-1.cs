namespace Pilha-Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha minhaPilha = new Pilha(20);
            Console.Write("Informe a expressão: ");
            string expressao = Console.ReadLine();
            double res = 0;
            for (int i = 0; i < expressao.Length; i++)
            {
                if (expressao[i] != '+' && expressao[i] != '-' && expressao[i] != '*' && expressao[i] != '/')
                {
                    int numeros = (int)char.GetNumericValue(expressao[i]);
                    minhaPilha.Empilhar(numeros);
                }
                else
                {
                    char operador = expressao[i];
                    double num1 = minhaPilha.Desempilhar();
                    double num2 = minhaPilha.Desempilhar();
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
                        if (num1 == 0)
                        {
                            Console.WriteLine("erro");
                        }
                        res = num2 / num1;
                    }
                    minhaPilha.Empilhar(res);
                }
            }
            Double resultado = minhaPilha.Desempilhar();
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}