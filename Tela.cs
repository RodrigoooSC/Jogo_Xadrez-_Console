using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace Jogo_Xadrez___Console
{
    class Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            Console.WriteLine();
            imprimirTabuleiro(partida.tab); // Imprimi o tabuleiro no console

            Console.WriteLine();
            imprimirPecasCapturadas(partida); // Imprimi as peças capturadas 

            Console.WriteLine();
            Console.WriteLine("# Turno: " + partida.turno);
            Console.WriteLine("# Aguardando jogada: " + partida.jogadorAtual);
            if (partida.xeque)
            {
                Console.WriteLine("XEQUE!");
            }
        }
        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas ");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor; // Cor original
            Console.ForegroundColor = ConsoleColor.Blue;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[ ");
            foreach(Peca x in conjunto)
            {
                Console.Write(x + " ");
                
            }
            Console.Write(" ]");
        }
        public static void imprimirTabuleiro(Tabuleiro tab) // Monta na tela o tabuleiro com as peças
        {

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " "); // Colocar numeração lateral do tabuleiro
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j)); // Metodo de imprimir as peças coloridas                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis) // Monta na tela o tabuleiro com as possiveis posições da peça
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoMarcado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j] == true)
                    {
                        Console.BackgroundColor = fundoMarcado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }

                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
            Console.BackgroundColor = fundoOriginal;

        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
        public static void imprimirPeca(Peca peca) // Preenchimento de cor das peças do tabuleiro
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca) // Peças Brancas
                {
                    Console.Write(peca);
                }
                else // Peças Pretas
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
