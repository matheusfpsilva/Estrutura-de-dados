using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila-Celula
{
    internal class Fila
    {
        private Celula tras;
        private Celula frente;
        public Fila()
        {
            Celula sentinela = new Celula();
            tras = sentinela;
            frente = sentinela;
        }
        public bool filaVazia()
        {
            if (frente == tras) return true;
            else  return false;
        }
        public void enfileirar(String enf)
        {
            Celula nova = new Celula(enf);
            tras.Proximo = nova;
            tras = nova;  
        }
        public String desenfileirar()
        {
            Celula desenfileirado, proxCelula;
            if (!filaVazia())
            {
                desenfileirado = frente.Proximo;
                proxCelula = desenfileirado.Proximo;
                frente.Proximo = proxCelula;
                if (desenfileirado == tras)
                    tras = frente;
                return desenfileirado.Item;
            }
            else throw new Exception("Fila vazia!");
        }
        public int quantidade()
        {
            if (!filaVazia())
            {
                int contador = 0;
                Celula aux = frente;
                while (aux != tras)
                {
                    contador++;
                    aux = aux.Proximo;
                }
                return contador;
            }
            else throw new Exception("Fila vazia!");
        }
        public String primeiro()
        {
            if (!filaVazia())
                return frente.Proximo.Item;
            else throw new Exception("Fila vazia!");
        }
        public void imprimir()
        {
            Celula aux;
            if (!filaVazia())
            {
                Console.WriteLine("Aviões:");
                aux = frente.Proximo;
                while (aux != null)
                {
                    aux.Item.imprimir();
                    aux = aux.Proximo;
                }
            }
            else throw new Exception("Não foi possível imprimir o conteúdo da fila: a fila está vazia!");
        }
    }
}

