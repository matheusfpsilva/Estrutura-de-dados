namespace Fila-vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila Fila = new Fila(20);
            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Inserir arquivo na fila de impressão");
                Console.WriteLine("2 - Executar impressão");
                Console.WriteLine("3 - Exibir fila de impressão");
                Console.WriteLine("4 - Sair");
                int opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 4)
                {
                    Console.WriteLine("Opcão inválida!");
                    continue;
                }
                else if (opc == 1)
                {
                    Console.Write("Informe o nome do arquivo: ");
                    string nome = Console.ReadLine();
                    Console.Write("Infore o número de páginas do arquivo: ");
                    int paginas = int.Parse(Console.ReadLine());
                    Arquivo arq = new Arquivo(nome, paginas);
                    Fila.enfileirar(arq);
                }
                else if (opc == 2)
                {
                    if (Fila.filaVazia())
                        Console.WriteLine("Fila vazia!");
                    else
                        Fila.desenfileirar();
                }
                else if (opc == 3)
                {
                    if (Fila.filaVazia())
                        Console.WriteLine("Fila vazia!");
                    else
                        Fila.imprimir();
                }
                else
                {
                    Console.WriteLine("Programa finalizado!");
                    break;
                }
                Console.WriteLine("----------------------------------------------------------");
            }
        }
    }
}