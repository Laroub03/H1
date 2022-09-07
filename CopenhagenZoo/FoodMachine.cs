using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keeper;

namespace Food
{
    internal class FoodMachine
    {

        private string _food;

        private static FoodMachine? instance = null;


        protected internal string Food
        {
            get { return _food; }
            private set { _food = value; }
        }

        protected internal static FoodMachine Instance
        {
            get
            {
                instance = new FoodMachine();
                return instance;
            }
        }

        protected internal void AddFood()
        {
            Employee employee = new Employee();
            Random random = new Random();
            int randomIndex = random.Next(0, 2);
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1 || choice == 2 || choice == 3)
            {
                Console.WriteLine("Is the animal a Male or Female");
                string gender = Console.ReadLine();
                Console.WriteLine();
                if (randomIndex == 1)
                {
                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("The Zebra eats grass and it's gender is {1}", gender);
                            break;

                        case 2:
                            Console.WriteLine("The Tiger eats meat and it's gender is {1}", gender);
                            break;

                        case 3:
                            Console.WriteLine("The Hippo eats fruit and it's gender is {1}", gender);
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Monkeys are NOT allowed to operate this machine. GO AWAY!");
                }
            }
            else
            {
                Console.WriteLine("\nWhat is the employee's new name?");
                employee.Name = Console.ReadLine();
                Console.WriteLine("The employee's new name is {0}", employee.Name);
            }
        }
    }
}