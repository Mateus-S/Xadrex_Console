// See https://aka.ms/new-console-template for more information
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.Xadrex;

namespace xadrez_console
{
    class Program
    {
        static void Main( string [] args)
        {
            try
            {
                PartidaDeXadrex partida = new PartidaDeXadrex();

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e )
            {

                Console.WriteLine(e.Message);
            }

            
            Console.ReadLine();
        }
    }
}