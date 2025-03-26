using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDupla START, END, ld;
            START = END = null;
            int n, escolha;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("(1) - Insere um elemento na Lista Dupla");
                Console.WriteLine("(2) - Remove um elemento da Lista Dupla");
                Console.WriteLine("(3) - Imprime a Lista Dupla esquerda->direita");
                Console.WriteLine("(4) - Para SAIR");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        ld = new ListaDupla();
                        Console.Write("Entre com um número: ");
                        n = int.Parse(Console.ReadLine());
                        ld.Insere(n, ref START, ref END);
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Digite o número a ser removido: ");
                        n = int.Parse(Console.ReadLine());
                        ListaDupla.Remove(n, ref START, ref END);
                        break;

                    case 3:
                        Console.Clear();
                        ListaDupla.ImprimeEsquerdaDireita(START);
                        Console.ReadKey();
                        break;
                }
            } while (escolha != 4);
        }
    }
}
