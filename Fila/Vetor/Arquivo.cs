using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila-vetor
{
    internal class Arquivo
    {
        private string nome;
        private int paginas;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }
        public Arquivo(string nome, int paginas)
        {
            this.nome = nome;
            this.paginas = paginas;
        }
    }
}
