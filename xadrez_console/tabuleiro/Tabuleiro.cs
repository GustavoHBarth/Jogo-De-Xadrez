

using System.Reflection.Metadata.Ecma335;

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

        public Peca peca(Posicao pos) 
        {
            return pecas[pos.linha, pos.coluna];
        }

        //verificar se tem alguma peça na posição
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        
        //dar a posição para a peça e testar se já existe alguma peça na posição
        public void colcocarPeca(Peca p, Posicao pos) 
        
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já exite uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        //testar se a posição é valida ou não
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna >= colunas)
            {
                  return false;
            }
            return true; 
        }

        //validar a posição
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
        
    }
}
