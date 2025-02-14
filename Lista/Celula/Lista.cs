using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lista-Celula
{
    internal class Lista
    {
        private Celula primeiro;
        private Celula ultimo;
        private int tamanho;
        public Lista()
        {
            Celula sentinela = new Celula();
            primeiro = sentinela;
            ultimo = sentinela;
            tamanho = 0;
        }
        public bool listaVazia()
        {
            if(primeiro == ultimo)
                return true;
            else
                return false;
        }
        public void Inserir(int posicao, String novo)
        {
            Celula anterior, novaCelula, proximaCelula;
            if ((posicao >= 0) && (posicao <= tamanho))
            {
                anterior = primeiro;
                for (int i = 0; i < posicao; i++)
                {
                    anterior = anterior.Proximo;
                }
                novaCelula = new Celula(novo);
                proximaCelula = anterior.Proximo;
                anterior.Proximo = novaCelula;
                novaCelula.Proximo = proximaCelula;
                if (posicao == tamanho)
                {
                    ultimo = novaCelula;
                }
                tamanho++;
            }
            else throw new Exception("Posição inválida!");
        }
        public void Adicionar(String ins)
        {
            Celula novaCelula = new Celula(ins);
            if (listaVazia())
            {
                primeiro = novaCelula;
                ultimo = novaCelula;
            }
            else
            {
                ultimo.Proximo = novaCelula;
                ultimo = novaCelula;
            }
            tamanho++;           
        }
        public String RemoverPosicao(int posicao)
        {
            Celula anterior, celulaRemovida, proximaCelula;
            if (!listaVazia())
            {
                if ((posicao >= 0) && (posicao < tamanho))
                {
                    anterior = primeiro;
                    for (int i = 0; i < posicao; i++)
                    {
                        anterior = anterior.Proximo;
                    }
                    celulaRemovida = anterior.Proximo;
                    proximaCelula = celulaRemovida.Proximo;
                    anterior.Proximo = proximaCelula;
                    celulaRemovida.Proximo = null;
                    if (celulaRemovida == ultimo)
                    {
                        ultimo = anterior;
                    }
                    tamanho--;
                    return celulaRemovida.Item;
                }
                else throw new Exception("Posição inválida!");
            }
            else throw  new Exception("Lista vazia!");
        }
        public bool RemoverItem(String item)
        {
            if (!listaVazia())
            {
                Celula anterior = primeiro;
                Celula celulaRemovida = null;
                while (anterior.Proximo != null)
                {
                    if (anterior.Proximo.Item.Valor == item.Valor)
                    {
                        celulaRemovida = anterior.Proximo;
                        break;
                    }
                    anterior = anterior.Proximo;
                }
                if (celulaRemovida != null)
                {
                    Celula proximaCelula = celulaRemovida.Proximo;
                    anterior.Proximo = proximaCelula;
                    celulaRemovida.Proximo = null;
                    if (celulaRemovida == ultimo)
                    {
                        ultimo = anterior;
                    }
                    tamanho--;
                    return true;
                }
            }
            return false;
        }
        public String RemoverPrimeiro()
        {
            if (!listaVazia())
            {
                Celula celulaRemovida = primeiro.Proximo;
                Celula proximaCelula = celulaRemovida.Proximo;
                primeiro.Proximo = proximaCelula;
                celulaRemovida.Proximo = null;
                if (celulaRemovida == ultimo)
                {
                    ultimo = primeiro;
                }
                tamanho--;
                return celulaRemovida.Item;
            }
            else throw new Exception("Lista vazia!");
        }
        public String RemoverUltimo()
        {
            if (!listaVazia())
            {
                int posicao = tamanho - 1;
                Celula anterior = primeiro;
                for (int i = 0; i < posicao; i++)
                {
                    anterior = anterior.Proximo;
                }
                Celula celulaRemovida = anterior.Proximo;
                Celula proximaCelula = celulaRemovida.Proximo;
                anterior.Proximo = proximaCelula;
                celulaRemovida.Proximo = null;
                if (celulaRemovida == ultimo)
                {
                    ultimo = anterior;
                }
                tamanho--;
                return celulaRemovida.Item;
            }
            else throw new Exception("Lista vazia!");
        }
        public int Consta(string tempo)
        {
            int cont = 0;
            Celula atual = primeiro.Proximo; 
            while (atual != null)
            {
                if (atual.Item.Valor == tempo) 
                {
                    cont++;
                }
                atual = atual.Proximo;
            }
            return cont;
        }
        public bool Contem(String item)
        {
            Celula celulaAtual = primeiro;
            while (celulaAtual != null)
            {
                if (celulaAtual.Item.Valor == item.Valor)
                {
                    return true;
                }
                celulaAtual = celulaAtual.Proximo;
            }
            return false;
        }
        public int Contagem()
        {
            int contador = 0;
            Celula celulaAtual = primeiro;
            while (celulaAtual != null)
            {
                contador++;
                celulaAtual = celulaAtual.Proximo;
            }
            return contador;
        }
        public void imprimir()
        {
            Celula aux;
            if (!listaVazia())
            {
                aux = primeiro.Proximo;
                int i = 0;
                while (aux != null)
                {
                    Console.WriteLine("Posição " + i + ": ");
                    aux.Item.imprimir();
                    aux = aux.Proximo;
                    i++;
                }
            }
            else throw new Exception("Lista vazia!");
        }
    }
}
