using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameLoop = true;

            while (gameLoop)
            {
                Console.WriteLine("Pick one of the handsigns Rock, Paper or Scissors");
               string[] signs = { "Rock", "Paper", "Scissors" };
                string ChoosenSign = Console.ReadLine();
                Random random = new Random();
                int randomIndex = random.Next(1, 4);


                Console.Clear();
                for (int i = 0; i < signs.Length; i++)
                {
                    Console.WriteLine(signs[i]);
                    Thread.Sleep(1000);
                }
                Console.WriteLine("");
                switch (randomIndex)
                { 
                case 1:
                    if (ChoosenSign == signs[0])
                    {
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("It is a tie.");
                    }

                    else if (ChoosenSign == signs[1])
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("User wins");

                    }
                    else if (ChoosenSign == signs[2])
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("Computer wins");

                    }
                    break;

                case 2:
                    if (ChoosenSign == signs[0])
                    {
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("It is a tie");
                    }

                    else if (ChoosenSign == signs[1])
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("User wins");
                    }
                    else if (ChoosenSign == signs[2])
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("Computer wins");
                    }
                    break;

                case 3:
                    if (ChoosenSign == signs[0])
                    {
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("Computer chose Scissors");
                        Console.WriteLine("User wins.");
                    }

                    else if (ChoosenSign == signs[1])
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("Computer chose Scissors");
                        Console.WriteLine("Computer wins");

                    }
                    else if (ChoosenSign == signs[2])
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("Computer chose Scissors");
                        Console.WriteLine("It is a tie");
                    }
                    break;


                }
                Console.WriteLine("");
                Console.WriteLine("Game Over");
                Thread.Sleep(15000);
                Console.WriteLine("Do you wish to play again?");
                Console.WriteLine("Enter Y or N");

            string playAgain = Console.ReadLine();

            if (playAgain == "N" || playAgain == "n" || playAgain == "no")
            {
                gameLoop = false;

             }
            }
        }
    }
}