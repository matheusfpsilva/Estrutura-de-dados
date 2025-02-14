using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha-Celula
{
    internal class Double
    {
        private double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public Double(int valor)
        {
            this.valor = valor;
        }
        public Double()
        {
            valor = 0;
        }
    }
}
