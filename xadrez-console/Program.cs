//NET 6.0
using tabuleiro;
using xadrez;
try { 
Tabuleiro tab = new Tabuleiro(8, 8);

tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,6));
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 6));


    Tela.imprimirTabuleiro(tab);
}

catch(TabuleiroException e)
{
    Console.WriteLine("Erro: "+e.Message);
}