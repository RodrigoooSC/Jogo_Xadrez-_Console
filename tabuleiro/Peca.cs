namespace tabuleiro
{
    abstract class Peca // Camada tabuleiro
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qntdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qntdMovimentos = 0;
        }

        public void incrementarQntdMovimento()
        {
            qntdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();       
        
    }
}
