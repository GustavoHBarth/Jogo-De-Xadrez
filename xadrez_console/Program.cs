using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
               PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.termianda)
                {
                    //imprime o tabuleiro
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    //digita posição de origem
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    //digita posição de destino
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
            }

                catch (TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
