namespace Pilha-Celula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha minhaPilha = new Pilha();
            Console.Write("Informe a expressão: ");
            string expressao = Console.ReadLine();
            for (int i = 0; i < expressao.Length; i++)
            {
                if (expressao[i] != '+' && expressao[i] != '-' && expressao[i] != '*' && expressao[i] != '/')
                {
                    int numeros = (int)char.GetNumericValue(expressao[i]);
                    Double exp = new Double(numeros);
                    minhaPilha.empilhar(exp);
                }
                else
                {
                    char operador = expressao[i];
                    Double num1 = minhaPilha.desempilhar();
                    Double num2 = minhaPilha.desempilhar();
                    Double res = new Double();
                    if (operador == '+')
                    {
                        res.Valor = num1.Valor   + num2.Valor;
                    }
                    else if (operador == '-')
                    {
                        res.Valor = num2.Valor - num1.Valor;
                    }
                    else if (operador == '*')
                    {
                        res.Valor = num1.Valor  * num2.Valor;
                    }
                    else if (operador == '/')
                    {
                        if (num1.Valor == 0)
                        {
                            Console.WriteLine("erro");
                        }
                        res.Valor  = num2.Valor / num1.Valor;
                    }
                    minhaPilha.empilhar(res);
                }
            }
            Double topo = minhaPilha.consultarTopo();
            Console.WriteLine("Resposta: " + topo.Valor);
            Console.ReadKey();           
        }
    }
}