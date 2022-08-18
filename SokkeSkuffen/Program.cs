using System;

class Program
{

    static int socks(string name, int number)
    {

        int count = 0;

        List<string> list = new List<string>();

        for (int i = 0; i < number - 1;)
        {


            if (name[i] == name[i + 1])
            {
                count++;

                i = i + 2;
            }
            else
            {
                i++;
            }
        }
        return count;
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Write all the socks in your drawer");
        string name = Console.ReadLine();
        
        int number = name.Length;

        Console.WriteLine("The amount of pairs in your drawer is " + socks(name, number));
    }
}
