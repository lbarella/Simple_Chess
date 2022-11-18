using System;
using tabuleiro;
using xadrez;

namespace Simple_Chess
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    else
                    {
                        //Console.Write(tab.peca(i, j) + " ");
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        // Lê uma posição de xadrez inserida pelo usuário.
        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            
            char coluna = s[0]; // Pega a primeira posição da string, a letra da posição de xadrez.
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                // Mudo o Foreground Color para amarelo e depois volto ele na cor padrão.
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
