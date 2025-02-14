using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore-Binaria
{
    internal class No
    {
        private Inteiro item;
        private No esquerda, direita;
        public Inteiro Item
        {
            get { return item; }
            set { item = value; }
        }
        public No Esquerda
        {
            get { return esquerda; }
            set { esquerda = value; }
        }
        public No Direita
        {
            get { return direita; }
            set { direita = value; }
        }
        public No()
        {
            item = new Inteiro();
            esquerda = null;
            direita = null;
        }
        public No(Inteiro novo)
        {
            item = novo;
            esquerda = null;
            direita = null;
        }
    }
}
