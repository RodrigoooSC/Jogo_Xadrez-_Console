using System;
using tabuleiro;

namespace Jogo_Xadrez___Console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) // Monta na tela o tabuleiro com as peças
        {

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " "); // Colocar numeração lateral do tabuleiro
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j)); // Metodo de imprimir as peças coloridas
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
        }
        public static void imprimirPeca(Peca peca) // Preenchimento de cor das peças do tabuleiro
        {
            if (peca.cor == Cor.Branca) // Peças Brancas
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else // Peças Pretas
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
