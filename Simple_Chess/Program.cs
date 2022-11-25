using Simple_Chess;
using System;
using tabuleiro;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        Console.Write("\n- Posição de origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
       

        Console.Write("\n- Posição de destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);
    }
  
}

catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
