//NET 6.0
using tabuleiro;
using xadrez;

try { 
Tabuleiro tab = new Tabuleiro(8, 8);
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

    Tela.imprimirTabuleiro(tab);



}
catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}