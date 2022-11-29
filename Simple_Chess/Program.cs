using Simple_Chess;
using System;
using tabuleiro;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        try
        {
            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab);
            Console.Write("\n- Turno: " + partida.turno);
            Console.Write("\n- Aguardado jogada de: " + partida.jogadorAtual);

            Console.Write("\n- Posição de origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeOrigem(origem);

            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);


            Console.Write("\n- Posição de destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDestino(origem, destino);

            partida.realizaJogada(origem, destino);
        }

        catch(TabuleiroException e){
            Console.WriteLine(e.Message);
            Console.WriteLine("* Aperte ENTER para constinuar!");
            Console.ReadLine();
        }
    }
  
}

catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
