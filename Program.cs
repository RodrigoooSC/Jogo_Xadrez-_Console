using System;
using tabuleiro;
using xadrez;


namespace Jogo_Xadrez___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Quando for detectada alguma exceção dentro do bloco try ele interrompe o código e cai no catch exibindo o erro
            {
                Tabuleiro tab = new Tabuleiro(8, 8); // Intancia um tabuleiro 8x8

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 9));

                Tela.imprimirTabuleiro(tab); // Imprimi o tabuleiro no console
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
