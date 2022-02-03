using System;
using tabuleiro;

namespace Jogo_Xadrez___Console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) // Monta na tela o tabuleiro com as peças
        {
            for (int i = 0; i <tab.linhas; i++)
            {
                for (int j = 0; j <tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
