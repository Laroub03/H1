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
            string playAgain = "";
            do
            {
                Value[] _deck = game.CreateDeck();
                game.DeckShuffler(_deck);


                Player player = new Player();
                Player dealer = new Player();


                game.Draw(_deck, player);
                game.Draw(_deck, player);


                game.AceChecker(player);
                game.Hand(player);
                game.PointChecker(player);
                bool alive = true;

                string choice = "Undefined";

                while (alive == true && choice != "STICK")
                {
                    Console.Write("Hit or Stick? ");
                    choice = Console.ReadLine().ToUpper();
                    if (choice == "HIT")
                    {
                        game.Draw(_deck, player);


                        game.Hand(player);
                        alive = game.PointChecker(player);
                    }
                }

                if (alive == true)
                {
                    bool dealerAlive = true;

                    Console.WriteLine();
                    Console.WriteLine("*** Dealer's Turn ***");
                    game.Draw(_deck, dealer);
                    game.Draw(_deck, dealer);

                    game.AceChecker(dealer);
                    game.Hand(dealer);
                    game.PointChecker(dealer);

                    while (dealerAlive == true)
                    {
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        game.Draw(_deck, dealer);

                        game.AceChecker(dealer);
                        game.Hand(dealer);
                        dealerAlive = game.PointChecker(dealer);
                    }
                }

                game.calculateWinner(player, dealer);

                Console.Write("Do you want to play again? Y/N ");
                playAgain = Console.ReadLine().ToUpper();
            } while (playAgain == "Y");
        }

    }
    }



