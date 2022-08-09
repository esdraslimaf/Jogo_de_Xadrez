//NET 6.0
using tabuleiro;
using xadrez; 


Tabuleiro tab = new Tabuleiro(8, 8);

tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));


Tela.imprimirTabuleiro(tab);