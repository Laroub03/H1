using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cakes = { "Kartoffelkage", "Mocca Eclair", "Fragilité", "Harmonie", "Magrethekage", "Lyonsnitte", "Marzarin", "Sarah Bernhardt", "Carl Nielsen", "Prinsesse Thyra" };
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
            int randomIndex = random.Next(0, 10);
            string selectedCake = cakes[randomIndex];


            bool contains = false;

            for (int j = 0; j < 3 ; j++)
            {
                Console.WriteLine("Enter the name of the cakes you want to pratice");
                string praticedCakes = Console.ReadLine();
                if (praticedCakes == selectedCake)
                {
                    contains = true;
                }

            }

            if (contains == true)
            {
                Console.WriteLine("You passed the exam {0} was the right cake", selectedCake);
                    break;
            }
                else
                {
                    Console.WriteLine("You failed the exam {0} was the right cake. Try Again!", selectedCake);
                }
                Console.WriteLine("");
            }        


         }   
    }
}