using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao() // Converte as posições do xadrez convencional(A1,B2,C3) para as linhas e colunas da matriz (1,1 / 2,2 / 3,3)
        {
            return new Posicao(8 - linha,coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
