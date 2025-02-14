using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila-Celula
{
    internal class String
    {
        private string valor;
        public String(string valor)
        {
            this.valor = valor;
        }
        public string Valor { get { return valor; } set { valor = value; } }
        public String()
        {
            valor = null;
        }
        public void imprimir()
        {
            Console.WriteLine(valor);
        }
    }
}
