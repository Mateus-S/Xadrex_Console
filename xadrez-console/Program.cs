// See https://aka.ms/new-console-template for more information
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.Xadrex;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                PartidaDeXadrex partida = new PartidaDeXadrex();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem:  ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis(); 

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
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