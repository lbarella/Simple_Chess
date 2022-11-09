using Simple_Chess;
using System;
using tabuleiro;
using xadrez;

try
{
    PosicaoXadrez pos = new PosicaoXadrez('f', 4);

    Console.WriteLine(pos);
    Console.WriteLine(pos.toPosicao());
}

catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
