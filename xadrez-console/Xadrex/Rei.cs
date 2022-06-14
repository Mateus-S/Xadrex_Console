using xadrez_console;

namespace xadrez_console.Xadrex
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
