

namespace tabuleiro
{
     class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        
        //dar a posição para a peça
        public void colcocarPeca(Peca p, Posicao pos) 
        
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

    }
}
