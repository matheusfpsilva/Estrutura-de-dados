using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista-Vetor
{
    internal class Site
    {
        private string nome;
        private string link;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        public Site(string nome, string link)
        {
            this.nome = nome;
            this.link = link;
        }
        public Site()
        {
            nome = null;
            link = null;
        }
        public void imprimir()
        {
            Console.WriteLine("Nome: " + nome + ", " + "Link: " + link);
        }
    }
}
