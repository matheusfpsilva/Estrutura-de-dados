namespace Arvore-Binaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arvore arvore = new Arvore();
            while (true)
            {
                Console.WriteLine("1- Inserir um número na árvore binária de busca\n" +
                    "2- Remover um número da árvore binária de busca\n" +
                    "3- Pesquisar um número na árvore binária de busca\n" +
                    "4- Mostrar o maior elemento da árvore binária de busca\n" +
                    "5- Mostrar o menor elemento da árvore de pesquisa de busca\n" +
                    "6- Mostrar todos os elementos da árvore, usando o caminhamento central\n" +
                    "7- Mostrar todos os elementos da árvore, usando o caminhamento pós-ordem\n" +
                    "8- Mostrar todos os elementos da árvore, usando o caminhamento pré-ordem\n" +
                    "9- Sair");
                int opc = int.Parse(Console.ReadLine());
                if (opc < 1 || opc > 9)
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }
                if (opc == 1)
                {
                    Console.Write("Informe o número: ");
                    int num = int.Parse(Console.ReadLine());
                    Inteiro novo = new Inteiro(num);
                    arvore.inserir(novo);
                    Console.WriteLine("Número adicionado!");
                }
                else if (opc == 2)
                {
                    Console.Write("Informe o número a ser removido: ");
                    int num = int.Parse(Console.ReadLine());
                    arvore.remover(num);
                    Console.WriteLine("Número removido!");
                }
                else if (opc == 3)
                {
                    Console.Write("Informe o número a ser pesquisado: ");
                    int num = int.Parse(Console.ReadLine());
                    Inteiro pesquisado = arvore.pesquisar(num);
                    Console.WriteLine("Valor encontrado: " + pesquisado.Valor);
                }
                else if (opc == 4)
                {
                    int maior = arvore.maiorElemento();
                    Console.WriteLine("Maior elemento: " + maior.ToString());
                }
                else if (opc == 5)
                {
                    int menor = arvore.menorElemento();
                    Console.WriteLine("Menor elemento: " + menor.ToString());
                }
                else if (opc == 6)
                    arvore.caminhamentoCentral();
                else if (opc == 7)
                    arvore.caminhamentoPosOrdem();
                else if (opc == 8)
                    arvore.maiorMenor();
                else{
                    Console.WriteLine("Programa encerrado!");
                    break;
                }
                Console.WriteLine("-----------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}