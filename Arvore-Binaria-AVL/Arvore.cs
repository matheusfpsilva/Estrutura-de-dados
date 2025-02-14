using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvore-AVL
{
    internal class Arvore
    {
        private No raiz;
        public Arvore()
        {
            raiz = null;
        }
        private No rotacionarDireita(No p)
        {
            No u = p.Esquerda;
            No filhoEsquerdaDireita = u.Direita;
            u.Direita = p;
            p.Esquerda = filhoEsquerdaDireita;
            p.setAltura();
            u.setAltura();
            return u;
        }
        private No rotacionarEsquerda(No p)
        {
            No z = p.Direita;
            No filhoDireitaEsquerda = z.Esquerda;
            z.Esquerda = p;
            p.Direita = filhoDireitaEsquerda;
            p.setAltura();
            z.setAltura();
            return z;
        }
        private No balancear(No raizSubarvore)
        {
            int fatorBalanceamento;
            int fatorBalanceamentoFilho;
            fatorBalanceamento = raizSubarvore.getFatorBalanceamento();
            if (fatorBalanceamento == 2)
            {
                fatorBalanceamentoFilho = raizSubarvore.Esquerda.getFatorBalanceamento();
                if (fatorBalanceamentoFilho == -1)
                {
                    raizSubarvore.Esquerda = rotacionarEsquerda(raizSubarvore.Esquerda);
                }
                raizSubarvore = rotacionarDireita(raizSubarvore);
            }
            else if (fatorBalanceamento == -2)
            {
                fatorBalanceamentoFilho = raizSubarvore.Direita.getFatorBalanceamento();
                if (fatorBalanceamentoFilho == 1)
                {
                    raizSubarvore.Direita = rotacionarDireita(raizSubarvore.Direita);
                }
                raizSubarvore = rotacionarEsquerda(raizSubarvore);
            }
            else
                raizSubarvore.setAltura();
            return raizSubarvore;
        }
        public void inserir(Inteiro valorNovo)
        {
            this.raiz = inserir(this.raiz, valorNovo);
        }
        private No inserir(No raizSubarvore, Inteiro valorNovo)
        {
            if (raizSubarvore == null)
                raizSubarvore = new No(valorNovo);
            else if (valorNovo.Valor == raizSubarvore.Item.Valor)
                throw new Exception("Valor já inserido anteriormente!");
            else if (valorNovo.Valor < raizSubarvore.Item.Valor)
                raizSubarvore.Esquerda = inserir(raizSubarvore.Esquerda, valorNovo);
            else
                raizSubarvore.Direita = inserir(raizSubarvore.Direita, valorNovo);
            return balancear(raizSubarvore);
        }
        private No antecessor(No noRetirar, No raizSubarvore)
        {
            if (raizSubarvore.Direita != null)
                raizSubarvore.Direita = antecessor(noRetirar, raizSubarvore.Direita);
            else
            {
                noRetirar.Item = raizSubarvore.Item;
                raizSubarvore = raizSubarvore.Esquerda;
            }
            return balancear(raizSubarvore);
        }
        public void remover(int valorRemover)
        {
            this.raiz = remover(this.raiz, valorRemover);
        }
        private No remover(No raizSubarvore, int valorRemover)
        {
            if (raizSubarvore == null)
                throw new Exception("Valor não encontrado!");
            else if (valorRemover == raizSubarvore.Item.Valor)
            {
                if (raizSubarvore.Esquerda == null)
                    raizSubarvore = raizSubarvore.Direita;
                else if (raizSubarvore.Direita == null)
                    raizSubarvore = raizSubarvore.Esquerda;
                else
                    raizSubarvore.Esquerda = antecessor(raizSubarvore, raizSubarvore.Esquerda);
            }
            else if (valorRemover > raizSubarvore.Item.Valor)
                raizSubarvore.Direita = remover(raizSubarvore.Direita, valorRemover);
            else
                raizSubarvore.Esquerda = remover(raizSubarvore.Esquerda, valorRemover);
            return balancear(raizSubarvore);
        }
        public Inteiro pesquisar(int valorPesquisar)
        {
            return pesquisar(this.raiz, valorPesquisar);
        }
        private Inteiro pesquisar(No raizSubarvore, int valorPesquisar)
        {
            if (raizSubarvore == null)
                return null;
            else if (valorPesquisar == raizSubarvore.Item.Valor)
                return raizSubarvore.Item;
            else if (valorPesquisar > raizSubarvore.Item.Valor)
                return pesquisar(raizSubarvore.Direita, valorPesquisar);
            else
                return pesquisar(raizSubarvore.Esquerda, valorPesquisar);
        }
        public void caminhamentoCentral()
        {
            caminhamentoCentral(this.raiz);
        }
        private void caminhamentoCentral(No raizSubarvore)
        {
            if (raizSubarvore != null)
            {
                caminhamentoCentral(raizSubarvore.Esquerda);
                raizSubarvore.Item.imprimir();
                caminhamentoCentral(raizSubarvore.Direita);
            }
        }
        public void caminhamentoPosOrdem()
        {
            caminhamentoPosOrdem(this.raiz);
        }
        private void caminhamentoPosOrdem(No raizSubarvore)
        {
            if (raizSubarvore != null)
            {
                caminhamentoPosOrdem(raizSubarvore.Esquerda);
                caminhamentoPosOrdem(raizSubarvore.Direita);
                raizSubarvore.Item.imprimir();
            }
        }
        public void caminhamentoPreOrdem()
        {
            caminhamentoPreOrdem(this.raiz);
        }
        private void caminhamentoPreOrdem(No raizSubarvore)
        {
            if (raizSubarvore != null)
            {
                raizSubarvore.Item.imprimir();
                caminhamentoPreOrdem(raizSubarvore.Esquerda);
                caminhamentoPreOrdem(raizSubarvore.Direita);
            }
        }
    }
}

