using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Change namespace
namespace Automaten.Logic
{
    internal class VendingMachine
    {
        //TODO: Manager
        
        
        //List of snacks
        protected internal int vendingBal = 20;
        protected internal List<Snack> drpepperList = new List<Snack>();
        protected internal List<Snack> marabouList = new List<Snack>();
        protected internal List<Snack> hariboList = new List<Snack>();

                Snack drpepper = new Snack("Dr. Pepper", 20);
                Snack marabou = new Snack("Marabou", 20);
                Snack haribo = new Snack("Haribo", 20);
        protected internal VendingMachine() //loop that counts the amount of snacks in the vm
        {
            for (int i = 0; i < 10; i++)
            {
                drpepperList.Add(drpepper);
            }
            for (int i = 0; i < 4; i++)
            {
                marabouList.Add(marabou);
            }
            for (int i = 0; i < 6; i++)
            {
                hariboList.Add(haribo);
            }
        }
            //Shows snacks
            protected internal string ShowSnacks()
            {
                string str;
                str = 
                "1. " + drpepperList[0].Name + " " + drpepperList[0].Price + "DKK " + drpepperList.Count + " left\n" + 
                "2. " + marabouList[0].Name + " " + marabouList[0].Price + "DKK " + marabouList.Count + " left\n" + 
                "3. " + hariboList[0].Name + " " + hariboList[0].Price + "DKK " + hariboList.Count + " left\n";

                return str;
            }
            // Returns change if inputtet money was over the product price

            // All 3 get methods gives you your picked snack as long as there is more than 0 in the vm
            protected internal void GetSlot1()
            {
                if (drpepperList.Count > 0)
                {
                    drpepperList.RemoveAt(0);
                    vendingBal += drpepperList[0].Price;
                }
            }
            protected internal void GetSlot2()
            {
                if (drpepperList.Count > 0)
                {
                    marabouList.RemoveAt(0);
                    vendingBal += marabouList[0].Price;

                }
            }
            protected internal void GetSlot3()
            {
                if (hariboList.Count > 0)
                {
                    hariboList.RemoveAt(0);
                    vendingBal += hariboList[0].Price;
                }
            }
            // Method that displays amount to admin
            protected internal string DisplaySnacksAmount()
            {
                string str;
                str = 
                "1. " + drpepperList[0].Name + " " + drpepperList.Count + " left\n" + 
                "2. " + marabouList[0].Name + " " + marabouList.Count + " left\n" + 
                "3. " + hariboList[0].Name + " " + hariboList.Count + " left\n";

                return str;
            }
            //Allows admin to restock the vm
            protected internal string FillStock(int amount, int product)
            {
                if (product == 1)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        drpepperList.Add(drpepper);
                    }
                    return "Restocked with " + amount + 
                    " Dr. Pepper's there is now " + drpepperList.Count + " Dr. Pepper's in stock";
                }
                else if (product == 2)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        marabouList.Add(marabou);
                    }
                    return "Restocked with " + amount + 
                    " Marabou's there is now " + marabouList.Count + " Marabou's in stock";
                }
                else if (product == 3)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        hariboList.Add(haribo);
                    }
                    return "Restocked with " + amount + 
                    " Haribo's there is now " + hariboList.Count + " Haribo's in stock";
                }
                return "";
            }
            //Method for admin to change the price
            protected internal string ChangePrice(int product, int price)
            {
                if (product == 1)
                {
                    drpepperList[0].Price = price; // Gives the price value a new value
                    return "Price of Dr. Pepper has been changed to " + drpepperList[0].Price; 

                }
                else if (product == 2)
                {
                    marabouList[0].Price = price;
                    return "Price of Marabou has been changed to " + marabouList[0].Price;

                }
                else if (product == 3)
                {
                    hariboList[0].Price = price;
                    return "Price of Haribo has been changed to " + hariboList[0].Price;
                }
                return "";

            }
        }
    }

