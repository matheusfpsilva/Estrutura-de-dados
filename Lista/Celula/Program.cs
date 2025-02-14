namespace Lista-Celula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
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
                    String ins = new String(tempo.ToString());
                    lista.Inserir(0, ins);
                    Console.WriteLine("Tempo inserido!");
                }
                else if (opc == 2)
                {
                    Console.Write("Informe um tempo: ");
                    double tempo = double.Parse(Console.ReadLine());
                    String ins = new String(tempo.ToString());
                    lista.Adicionar(ins);
                    Console.WriteLine("Tempo inserido!");
                }
                else if (opc == 3)
                {
                    Console.Write("Informe um tempo: ");
                    double tempo = double.Parse(Console.ReadLine());
                    String ins = new String(tempo.ToString());
                    Console.Write("Informe a posição para adicioná-lo: ");
                    int posicao = int.Parse(Console.ReadLine());
                    if (posicao >= 0 && posicao <= lista.Contagem())
                    {
                        lista.Inserir(posicao, ins);
                        Console.WriteLine("Tempo inserido!");
                    }
                    else
                        Console.WriteLine("Posição inválida!");
                }
                else if (opc == 4)
                {
                    if (!lista.listaVazia())
                    {
                        String removido = lista.RemoverPrimeiro();
                        Console.WriteLine("Tempo removido: " + removido.Valor);
                    }
                    else
                        Console.WriteLine("Lista vazia!");
                }
                else if (opc == 5)
                {
                    if (!lista.listaVazia())
                    {
                        String removido = lista.RemoverUltimo();
                        Console.WriteLine("Tempo removido: " + removido.Valor);
                    }
                    else
                        Console.WriteLine("Lista vazia!");
                }
                else if (opc == 6)
                {
                    Console.Write("Informe a posição para retirar um tempo: ");
                    int posicao = int.Parse(Console.ReadLine());
                    if (posicao >= 0 && posicao < lista.Contagem())
                    {
                        String removido = lista.RemoverPosicao(posicao);
                        Console.WriteLine("Tempo removido: " + removido.Valor);
                    }
                    else
                        Console.WriteLine("posição inválida!");
                }
                else if (opc == 7)
                {
                    Console.Write("Informe um tempo para ser retirado: ");
                    double tempo = double.Parse(Console.ReadLine());
                    String item = new String(tempo.ToString());
                    if (lista.Contem(item))
                    {
                        lista.RemoverItem(item);
                        Console.WriteLine("Tempo removido!");
                    }
                    else
                        Console.WriteLine("tempo inválido!");
                }
                else if (opc == 8)
                {
                    Console.Write("Informe um tempo: ");
                    double tempo = double.Parse(Console.ReadLine());
                    int consta = lista.Consta(tempo.ToString());
                    Console.WriteLine("consta {0} vez(es)", consta);
                }
                else if (opc == 9)
                {
                    Console.WriteLine("Tempos: ");
                    lista.imprimir();
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