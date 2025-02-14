namespace Fila-Celula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            String novo = new String("aviao1");
            fila.enfileirar(novo);
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
                    if (fila.filaVazia())
                        Console.WriteLine("Fila vazia!");
                    else
                        Console.WriteLine("Quantidade de aviões: " + fila.quantidade());
                }
                else if (opc == 2)
                {
                    if (fila.filaVazia())
                        Console.WriteLine("Fila vazia!");
                    else
                        Console.WriteLine("avião decolado: " + fila.desenfileirar().Valor);
                }
                else if (opc == 3)
                {
                    Console.WriteLine("Novo avião: ");
                    string enf = Console.ReadLine();
                    String enfileirado = new String(enf);
                    fila.enfileirar(enfileirado);
                    Console.WriteLine("avião adicionado");
                }
                else if (opc == 4)
                {
                    if (fila.filaVazia())
                        Console.WriteLine("Fila vazia!");
                    else
                        fila.imprimir();
                }
                else if (opc == 5)
                {
                    if (fila.filaVazia())
                        Console.WriteLine("Fila vazia!");
                    else
                    {
                        String primeiro = fila.primeiro();
                        Console.WriteLine("primeiro avião: " + primeiro.Valor);
                    }
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