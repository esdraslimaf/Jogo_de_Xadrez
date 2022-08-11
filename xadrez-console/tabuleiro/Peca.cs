
namespace tabuleiro
{
    abstract class Peca
    {
        
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) // VAI SER CRIADO OBJETO PEÇA COM POSIÇÃO NULA, MAS AO COLOCAR A ColocarPeca(peca, posicao)
        {                                                   // vai ser definida a posição da peca.
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public abstract bool[,] movimentosPossiveis();











        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }



    }
}
