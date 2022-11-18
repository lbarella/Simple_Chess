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
        Console.Write("- Posição de destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);
    }
  
}

catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
