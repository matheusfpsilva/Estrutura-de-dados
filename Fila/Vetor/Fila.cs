using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila-vetor
{
    internal class Fila
    {
        private Arquivo[] fila;
        private int tamanho;
        private int frente;
        private int tras;
        public Fila(int tamanho)
        {
            this.tamanho = tamanho;
            fila = new Arquivo[tamanho];
            frente = 0;
            tras = 0;
        }
        public bool filaVazia()
        {
            if (frente == tras) return true;
            else return false;
        }
        public bool filaCheia()
        {
            if (((tras + 1) % tamanho) == (frente % tamanho)) return true;
            else return false;
        }
        public void enfileirar(Arquivo enf)
        {
            if (!filaCheia())
            {
                fila[tras % tamanho] = enf;
                tras++;
            }
            else
                throw new Exception("Fila cheia!");
        }
        public Arquivo desenfileirar()
        {
            Arquivo desf;
            if (!filaVazia())
            {
                desf = fila[frente % tamanho];
                frente++;
                return desf;
            }
            else
                throw new Exception("Fila vazia!");
        }
        public void imprimir()
        {
            if (!filaVazia())
            {
                Console.WriteLine("Arquivos:");
                for (int i = frente; i < tras; i++)
                {
                    Console.WriteLine("Nome: " + fila[i % tamanho].Nome +", " + "Páginas: " + fila[i%tamanho].Paginas);                 
                }
            }
        }
    }
}
