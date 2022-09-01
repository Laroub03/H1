using System;
using System.Linq.Expressions;
using System.Numerics;
using static System.Reflection.Metadata.BlobBuilder;


namespace Blackjack
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            Console.ReadLine();

        }
    }
}


