﻿using Simple_Chess;
using System;
using tabuleiro;
using xadrez;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 8));



    Tela.imprimirTabuleiro(tab);
    Console.WriteLine();
}

catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
