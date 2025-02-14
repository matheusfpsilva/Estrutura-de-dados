namespace Arvore-AVL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arvore arvore = new Arvore();
            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1- Inserir um número na árvore AVL\n" +
                    "2- Remover um número da árvore AVL\n" +
                    "3- Pesquisar um número na árvore AVL\n" +
                    "4- Mostrar todos os elementos da árvore AVL, usando o caminhamento central\n" +
                    "5- Mostrar todos os elementos da árvore AVL, usando o caminhamento pós-ordem\n" +
                    "6- Mostrar todos os elementos da árvore AVL, usando o caminhamento pré-ordem\n" +
                    "7- Sair");
                int opc = int.Parse(Console.ReadLine());
                if(opc < 1 || opc > 7)
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }
                if (opc == 1)
                {
                    Console.Write("Informe o número a ser inserido: ");
                    int num = int.Parse(Console.ReadLine());
                    Inteiro valorNovo = new Inteiro(num);
                    arvore.inserir(valorNovo);
                    Console.WriteLine("Número inserido!");
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
                    Inteiro result = arvore.pesquisar(num);
                    Console.WriteLine("Valor encontrado: " + result.Valor);
                }
                else if (opc == 4)
                    arvore.caminhamentoCentral();
                else if (opc == 5)
                    arvore.caminhamentoPosOrdem();
                else if (opc == 6)
                    arvore.caminhamentoPreOrdem();
                else if(opc == 7)
                {
                    Console.WriteLine("Programa encerrado!");
                    break;
                }
                Console.WriteLine("------------------------------------------");                
            }
            Console.ReadKey();
        }
    }
}