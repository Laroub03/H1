using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Xml.Serialization;
using static System.Reflection.Metadata.BlobBuilder;
using Keeper;
using FoodDispenser;

namespace CopenhagenZoo
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //string[] food = { "grass", "meat", "Fruit" };

            FoodMachine Grass = new FoodMachine("Grass");
            FoodMachine Meat = new FoodMachine("Meat");
            FoodMachine Fruit = new FoodMachine("Fruit");
            List<FoodMachine> food = new List<FoodMachine>();
            food.Add(Grass);
            food.Add(Meat);
            food.Add(Fruit);


            Random random = new Random();
            int randomIndex = random.Next(0, 2);

                Console.Write("Your Employee ID is: ");
                employee.EmployeeID();
                Console.WriteLine("\nWhat is your name?");
                employee.Name = Console.ReadLine();

                Console.WriteLine("\n{0} what task do you want to do?", employee.Name);
                Console.WriteLine("1. Feed the Zebra");
                Console.WriteLine("2. Feed The Tiger");
                Console.WriteLine("3. Feed The Hippo");
                Console.WriteLine("4. Change Employee name (HR department Only!)");
                
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

                            Console.WriteLine("The Zebra eats {0} and it's gender is {1}", Grass.ToString(), gender);
                            break;

                        case 2:
                            Console.WriteLine("The Tiger eats {0} and it's gender is {1}", Meat, gender);
                            break;

                        case 3:
                            Console.WriteLine("The Hippo eats {0} and it's gender is {1}", Fruit, gender);
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
                Console.WriteLine("\nWhat is your new name?");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Your name is now {0}", employee.Name);
            }
        }
    }
}