using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.ReadLine();

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));


        }
    }
}
