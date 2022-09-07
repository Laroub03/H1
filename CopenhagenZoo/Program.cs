using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Xml.Serialization;
using static System.Reflection.Metadata.BlobBuilder;
using Keeper;
using Food;
using HRDepartment;


namespace CopenhagenZoo
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            //Keeper zookeeper = new Keeper("Carsten");
            //Animal animal = new Animal(((Animal.AnimalRace)0), true);
            //HR humananimal = new HR("Freja");

            // uses food dispenser
            //FoodDispenser.Instance.Foods("Zebra");


            Employee employee = new Employee();
            HR humanresources = new HR();
            FoodMachine foodmachine = new FoodMachine();




                Console.Write("Your Employee ID is: ");
                employee.EmployeeID();
                Console.Write("\nHR ID is: ");
                humanresources.AddHRID();
                
                Console.WriteLine("\n\nWhat is your name?");
                employee.Name = Console.ReadLine();

                Console.WriteLine("\nHR name?");
                humanresources.Name = Console.ReadLine();

            Console.WriteLine("\n{0} what task do you want to do?", employee.Name);
            Console.WriteLine("1. Feed the Zebra");
            Console.WriteLine("2. Feed The Tiger");
            Console.WriteLine("3. Feed The Hippo");
            Console.WriteLine("4. Change Employee name (HR department Only!)"); ;

                foodmachine.AddFood();

        }
    }
}