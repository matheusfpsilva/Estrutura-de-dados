using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha-Celula
{
    internal class Celula
    {
        private  Double item;
        private Celula proximo;
        public Double Item
        {
            get { return item; }
            set { item = value; }
        }
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        public Celula(Double emp)
        {
            item = emp;
            proximo = null;
        }
        public Celula()
        {
            item = new Double();
            proximo = null;
        }
    }
}
