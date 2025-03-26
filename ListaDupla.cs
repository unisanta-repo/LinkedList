using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDupla
{
    internal class ListaDupla
    {
        private int info;
        public ListaDupla next;
        public ListaDupla prior;

        public ListaDupla() // Construtor 
        {
            info = 0;
            next = prior = null;
        }

        public void Insere(int n, ref ListaDupla START, ref ListaDupla
   END)
        {
            this.info = n;
            if (START == null)
                START = END = this;
            else
            {
                END.next = this;
                this.prior = END;
                END = this;
            }
        }

        public static void Remove(int n, ref ListaDupla START, ref
   ListaDupla END)
        {
            ListaDupla atual = START;

            while (atual != null && atual.info != n)
            {
                atual = atual.next;
            }

            if (atual == null)
            {
                Console.WriteLine("Elemento não encontrado!");
                return;
            }

            if (atual == START)
                START = atual.next;
            if (atual == END)
                END = atual.prior;
            if (atual.prior != null)
                atual.prior.next = atual.next;
            if (atual.next != null)
                atual.next.prior = atual.prior;

            Console.WriteLine($"Elemento {n} removido!");
        }

        public static void ImprimeEsquerdaDireita(ListaDupla START)
        {
            ListaDupla atual = START;
            while (atual != null)
            {
                Console.Write(atual.info + " ");
                atual = atual.next;
            }
            Console.WriteLine();
        }
    }
}
