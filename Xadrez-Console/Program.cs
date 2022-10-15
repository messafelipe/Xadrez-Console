using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 4));
                //tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                PosicaoXadrez pos = new PosicaoXadrez('a', 1);

                Console.WriteLine(pos);
                Console.WriteLine(pos.ToPosicao());

                //Tela.ImprimirTabuleiro(pos);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.ReadLine();
        }
    }
}
