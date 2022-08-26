using System;

class Program
{

    public static void Main()
    {

        //Population
        Console.Write("\n Enter Current Population: ");
        decimal pop = decimal.Parse(Console.ReadLine());

        //Growth
        Console.Write("\n Enter Population Growth Rate: ");
        decimal growth = decimal.Parse(Console.ReadLine());
       growth = growth / 100;

        decimal test = calculator(pop, growth);
        Console.WriteLine("\n After 30 years the population increased to {0:n0} ", test);
    }

    static decimal calculator(decimal pop, decimal growth)
    {
        for (int i = 1; i <= 30; i++)
        {

            pop *= (1 + (growth/100));

        }
        return pop;
    }
}