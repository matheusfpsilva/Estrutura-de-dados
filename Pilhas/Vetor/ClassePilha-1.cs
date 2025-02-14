using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha-Vetor
{
    internal class Pilha
    {
        private double[] pilha;
        private int topo;
        public Pilha(int tam)
        {
            pilha = new double[tam];
            topo = 0;
        }
        public void Empilhar(double valor)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = valor;
                topo++;
            }
            else
            {
                Console.WriteLine("Pilha cheia!");
            }
        }
        public double Desempilhar()
        {
            if (topo > 0)
            {
                topo--;
                return pilha[topo];
            }
            else
            {
                throw new Exception("Pilha vazia!");
            }
        }

    }
}
