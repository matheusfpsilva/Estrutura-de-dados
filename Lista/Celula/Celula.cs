using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista-Celula
{
    internal class Celula
    {
        private String item;
        private Celula proximo;
        public String Item
        {
            get { return item; }
            set { item = value; }
        }
        public Celula Proximo
        {
            get { return proximo;}
            set { proximo = value;}
        }
        public Celula(String novo)
        {
            item = novo;
            proximo = null;
        }
        public Celula()
        {
            item = new String();
            proximo = null;
        }
    }
}
