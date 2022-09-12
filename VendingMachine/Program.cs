using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using static System.Reflection.Metadata.BlobBuilder;
using Automaten.Logic;


namespace Automaten.Model
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            //TODO: GUI

            VendingMachine vm = new();
            Customer customer = new();
            Admin admin = new();
            MainMenu();


            //Main Menu:
            void MainMenu()
            {
                Console.Clear();
            do
            {
                string choice = "";
                int input = 0;
                int i = 0;
                bool isRunning = true;
                int money = 0;
                Console.WriteLine("==================================================");
                Console.WriteLine("                  Vending Machine");
                Console.WriteLine("==================================================");
                Console.WriteLine("\n1. Order Snack");
                Console.WriteLine("2. Admin Menu");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Insert choice");


                int menuChoice = int.Parse(Console.ReadLine());


                switch (menuChoice)
                {
                    case 1:
                            
                            Console.WriteLine(vm.ShowSnacks()); //Shows all snacks
                            bool correctMoney = false;
                            do //while money is not enough the loop will repeat
                            {

                                Console.WriteLine("How much money you got?");
                                int moneyInput = int.Parse(Console.ReadLine());

                                money += moneyInput;
                                if (money >= 20)
                                {
                                    correctMoney = true;
                                }
                                else
                                {
                                    Console.WriteLine("You have not inserted enough money");

                                }
                            } while (correctMoney == false);

                            Console.WriteLine("Which snack do you want?");
                            input = int.Parse(Console.ReadLine());

                            Console.WriteLine("Do you want to make this purchase? y/n");

                            choice = Console.ReadLine().ToUpper();
                            if (choice== "Y")
                            {
                                // removes the product that was bought
                                if (money <= customer.cash)
                                {
                                    if (input == 1)
                                    {
                                        vm.GetSlot1();
                                    }
                                    else if (input == 2)
                                    {
                                        vm.GetSlot2();
                                    }
                                    else if (input == 3)
                                    {
                                        vm.GetSlot3();
                                    }

                                    Console.Clear();
                                    Console.WriteLine("Thank you for your purchase");
                                    Console.WriteLine("Your change: " + customer.GiveChange(money) + "DKK");
                                    customer.cash = customer.cash + customer.GiveChange(money);
                                    // vm uses an method to give any change

                                    Console.WriteLine("\nPress enter to continue");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                else { Console.Clear(); Console.WriteLine("You dont have enough money"); }
                            }
                            // User can cancel his order by typing n
                            else if (choice == "N")
                            {
                                Console.Clear();
                            }
                            break;

                    case 2:
                            AdminMenu();
                            break;

                    case 3:
                            Console.Clear();
                            Console.WriteLine("Thanks for using this vending machine!");
                            Environment.Exit(0);

                        break;
                    default:
                        break;
                }
            } while (true);
            }   

            //Admin Menu:
            void AdminMenu()
            {
                Console.Clear();
                do
                {
                Console.WriteLine("==================================================");
                Console.WriteLine("                     Admin Menu");
                Console.WriteLine("==================================================");
                Console.WriteLine("\n1. Refill Vending Machine");
                Console.WriteLine("2. Change price");
                Console.WriteLine("3. Collect money");
                Console.WriteLine("4. Go back to the main menu");
                Console.WriteLine("Insert choice");


                int adminChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                    switch (adminChoice)
                    {
                    case 1:
                            Console.WriteLine(vm.DisplaySnacksAmount());
                            Console.WriteLine("What product do you want to restock? ");
                            int product = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many do you want to fill?");
                            int amount = int.Parse(Console.ReadLine());
                            Console.WriteLine(vm.FillStock(amount, product));
                            break;

                    case 2:
                            Console.WriteLine(vm.ShowSnacks());
                            Console.WriteLine("What product do you want to change the price on? ");
                            int product1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("What should the price on the product be? ");
                            int price = int.Parse(Console.ReadLine());
                            Console.WriteLine(vm.ChangePrice(product1, price));

                            break;
                        case 3:
                            Console.WriteLine(admin.CollectMoney());
                            break;
                        case 4:
                            MainMenu();
                            break;
                    default:
                        break;
                    }
                } while (true);
            }
        }
    }
}