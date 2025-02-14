namespace Lista-Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(20);
            while (true)
            {
                Console.WriteLine("1) Inserir um Site no início da lista\n2) Inserir um Site no final da lista\n" +
                    "3) Inserir um Site numa posição específica da Lista\n4) Remover o primeiro Site da lista\n" +
                    "5) Remover o último Site da Lista\n6) Remover o Site de uma posição específica\n7) Mostrar o nome e o link de todos os sites\n" +
                    "8) Encerrar o programa");
                int opc = int.Parse(Console.ReadLine());
                if (opc < 1 || opc > 8)
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }
                if (opc == 1)
                {
                    Console.Write("Informe o nome do Site: ");
                    string nome = Console.ReadLine();
                    Console.Write("Informe o link do Site: ");
                    string link = Console.ReadLine();
                    Site novo = new Site(nome, link);
                    lista.Inserir(0, novo);
                }
                else if (opc == 2)
                {
                    Console.Write("Informe o nome do Site: ");
                    string nome = Console.ReadLine();
                    Console.Write("Informe o link do Site: ");
                    string link = Console.ReadLine();
                    Site novo = new Site(nome, link);
                    lista.Adicionar(novo);
                }
                else if (opc == 3)
                {
                    Console.Write("Informe a posição para inserir o Site: ");
                    int posicao = int.Parse(Console.ReadLine());
                    Console.Write("Informe o nome do Site: ");
                    string nome = Console.ReadLine();
                    Console.Write("Informe o link do Site: ");
                    string link = Console.ReadLine();
                    Site novo = new Site(nome, link);
                    lista.Inserir(posicao, novo);
                }
                else if (opc == 4)
                {
                      Site removido = lista.RemoverPrimeiro();
                      Console.WriteLine("Site removido: " + removido.Nome);
                }
                else if (opc == 5)
                {
                      Site removido = lista.RemoverUltimo();
                      Console.WriteLine("Site removido: " + removido.Nome);
                }
                else if (opc == 6)
                {
                    Console.Write("Informe a posição do Site a ser removido: ");
                    int posicao = int.Parse(Console.ReadLine());
                    Site removido = lista.RemoverPosicao(posicao);
                    Console.WriteLine("Site removido: " + removido.Nome);
                    
                }
                else if (opc == 7)
                {
                    lista.imprimir();
                }
                else if (opc == 8)
                {
                    Console.WriteLine("Programa encerrado!");
                    break;
                }
                Console.WriteLine("---------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}