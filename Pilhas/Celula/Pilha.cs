using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha-Celula
{
    internal class Pilha
    {
        private Celula fundo;
        private Celula topo;
        public Pilha()
        {
            Celula sentinela;
            sentinela = new Celula();
            fundo = sentinela;
            topo = sentinela;
        }
        public bool pilhaVazia()
        {
            if (topo == fundo)
                return true;
            else
                return false;
        }
        public void empilhar(Double emp)
        {
            Celula novaCelula;
            novaCelula = new Celula(emp);
            novaCelula.Proximo = topo;
            topo = novaCelula;
        }
        public Double desempilhar()
        {
            Celula desempilhado;
            if (!pilhaVazia())
            {
                desempilhado = topo;
                topo = topo.Proximo;
                desempilhado.Proximo = null;
                return (desempilhado.Item);
            }
            else
                throw new Exception("pilha vazia!");
        }
        public Double consultarTopo()
        {
            if (!pilhaVazia())
            {
                return (topo.Item);
            }
            else
                throw new Exception("pilha vazia!");
        }
    }
}

