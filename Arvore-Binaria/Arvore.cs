using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore-Binaria
{
    internal class Arvore
    {
        private No raiz;
        public Arvore()
        {
            raiz = null;
        }
        public Inteiro pesquisar(int objeto)
        {
            return pesquisar(this.raiz, objeto);
        }
        private Inteiro pesquisar(No raizSubarvore, int objeto)
        {
            if (raizSubarvore == null)
                return null;
            else if (objeto == raizSubarvore.Item.Valor)
                return raizSubarvore.Item;
            else if (objeto > raizSubarvore.Item.Valor)
                return pesquisar(raizSubarvore.Direita, objeto);
            else
                return pesquisar(raizSubarvore.Esquerda, objeto);
        }
        public void inserir(Inteiro novo)
        {
            this.raiz = inserir(this.raiz, novo);
        }
        private No inserir(No raizSubarvore, Inteiro novo)
        {
            if (raizSubarvore == null)
                raizSubarvore = new No(novo);
            else if (novo.Valor == raizSubarvore.Item.Valor)
                throw new Exception("Valor já existente!");
            else if (novo.Valor < raizSubarvore.Item.Valor)
                raizSubarvore.Esquerda = inserir(raizSubarvore.Esquerda, novo);
            else
                raizSubarvore.Direita = inserir(raizSubarvore.Direita, novo);
            return raizSubarvore;
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
            return raizSubarvore;
        }
        public void remover(int objRemovido)
        {
            this.raiz = remover(this.raiz, objRemovido);
        }
        private No remover(No raizSubarvore, int objRemovido)
        {
            if (raizSubarvore == null)
                throw new Exception("Valor não encontrado!");
            else if (objRemovido == raizSubarvore.Item.Valor)
            {
                if (raizSubarvore.Esquerda == null)
                    raizSubarvore = raizSubarvore.Direita;
                else if (raizSubarvore.Direita == null)
                    raizSubarvore = raizSubarvore.Esquerda;
                else
                    raizSubarvore.Esquerda = antecessor(raizSubarvore, raizSubarvore.Esquerda);
            }
            else if (objRemovido > raizSubarvore.Item.Valor)
                raizSubarvore.Direita = remover(raizSubarvore.Direita, objRemovido);
            else
                raizSubarvore.Esquerda = remover(raizSubarvore.Esquerda, objRemovido);
            return raizSubarvore;
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
        public int maiorElemento()
        {
            if (raiz == null)
                throw new InvalidOperationException("Árvore vazia!");
            return maiorElemento (raiz).Item.Valor;
        }
        private No maiorElemento(No raizSubarvore)
        {
            while (raizSubarvore.Direita != null)
            {
                raizSubarvore = raizSubarvore.Direita;
            }
            return raizSubarvore;
        }
        public int menorElemento()
        {
            if (raiz == null)
                throw new InvalidOperationException("Árvore vazia!");
            return menorElemento(raiz).Item.Valor;
        }
        private No menorElemento(No raizSubarvore)
        {
            while (raizSubarvore.Esquerda != null)
            {
                raizSubarvore = raizSubarvore.Esquerda;
            }
            return raizSubarvore;
        }
        public int contarNos()
        {
            return contarNos(this.raiz);
        }
        private int contarNos(No raizSubarvore)
        {
            if (raizSubarvore == null)
                return 0;
            return 1 + contarNos(raizSubarvore.Esquerda) + contarNos(raizSubarvore.Direita);
        }
        public int calcularAltura()
        {
            return calcularAltura(this.raiz);
        }
        private int calcularAltura(No raizSubarvore)
        {
            if (raizSubarvore == null)
                return 0;
            int alturaEsquerda = calcularAltura(raizSubarvore.Esquerda);
            int alturaDireita = calcularAltura(raizSubarvore.Direita);
            if (alturaEsquerda > alturaDireita)
                return alturaEsquerda + 1;
            else
                return alturaDireita + 1;
        }
        public void maiorMenor()
        {
            maiorMenor(this.raiz);
        }
        private void maiorMenor(No raizSubarvore)
        {
            if (raizSubarvore != null)
            {
                maiorMenor(raizSubarvore.Direita);
                raizSubarvore.Item.imprimir();
                maiorMenor(raizSubarvore.Esquerda);
            }
        }
    }
}
