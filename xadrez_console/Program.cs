using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //testando se permite geral um tabuleiro
            Tabuleiro tab = new Tabuleiro(8, 8);

            //colocar as pecas no tabuleiro
            tab.colcocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colcocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 3));
            tab.colcocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
