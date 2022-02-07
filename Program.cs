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
                Console.Title = "Jogo de Xadrez - Rodrigo Silva";
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.inicioJogo(partida);

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        // Origem
                        Console.WriteLine();
                        Console.Write("# Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis); // Imprimi o tabuleiro com as possiveis posições marcadas

                        // Destino
                        Console.WriteLine();
                        Console.Write("# Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("ATENÇÃO - " + e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            

        }
    }
}
