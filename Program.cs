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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab); // Imprimi o tabuleiro no console

                    Console.WriteLine("=============================");

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis); // Imprimi o tabuleiro com as possiveis posições marcadas

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
