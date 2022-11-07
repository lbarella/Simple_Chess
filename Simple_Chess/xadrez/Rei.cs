using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        // Retorna a letra R de Rei.
        public override string ToString()
        {
            return "R";
        }
    }
}
