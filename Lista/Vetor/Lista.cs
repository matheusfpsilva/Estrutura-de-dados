using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista-Vetor
{
    internal class Lista
    {
        private Site[] lista;
        private int primeiro;
        private int ultimo;
        private int tamanho;
        public Lista(int M)
        {
            lista = new Site[M];
            tamanho = 0;
            primeiro = 0;
            ultimo = 0;
        }
        public bool listaVazia()
        {
            if (primeiro == ultimo)
                return true;
            else
                return false;
        }
        public bool listaCheia()
        {
            if (ultimo == lista.Length)
                return true;
            else
                return false;
        }
        public void Inserir(int posicao, Site site)
        {
            if (!listaCheia())
            {
                if (posicao >= 0 && posicao <= tamanho)
                {
                    for (int i = ultimo; i > posicao; i--)
                    {
                        lista[i] = lista[i - 1];
                    }
                    lista[posicao] = site;
                    ultimo++;
                    tamanho++;
                }
                else throw new Exception("Posição inválida!");
            }
            else throw new Exception("Lista cheia!");
        }
        public void Adicionar(Site site)
        {
            if (!listaCheia())
            {
                lista[ultimo] = site;
                ultimo++;
                tamanho++;
            }
            else throw new Exception("Lista cheia!");
        }
        public Site RemoverPrimeiro()
        {
            if (!listaVazia())
            {
                Site removido = lista[primeiro];
                for (int i = primeiro; i < tamanho - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                ultimo--;
                tamanho--;
                return removido;
            }
            else throw new Exception("Lista vazia!");
        }
        public Site RemoverUltimo()
        {
            if (!listaVazia())
            {
                int posicao = tamanho - 1;
                Site removido = lista[posicao];
                for (int i = posicao; i < tamanho - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                tamanho--;
                ultimo--;
                return removido;
            }
            else throw new Exception("Lista vazia!");
        }
        public Site RemoverPosicao(int posicao)
        {
            Site removido;
            if (!listaVazia())
            {
                if (posicao >= 0 && posicao <= tamanho)
                {
                    for (int i = posicao; i < tamanho; i++)
                    {
                        lista[i] = lista[i + 1];
                    }
                    removido = lista[posicao];
                    tamanho--;
                    ultimo--;
                    return removido;
                }
                else throw new Exception("Posição inválida!");
            }
            else throw new Exception("Lista vazia!");
        }
        public void imprimir()
        {
            if (!listaVazia())
            {
                for (int i = primeiro; i < ultimo; i++)
                {
                    Console.WriteLine("Posição " + i + ": ");
                    lista[i].imprimir();
                }
            }
            else throw new Exception("Lista vazia!");
        }
    }
}
