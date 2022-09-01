using System.Drawing;
using System.Globalization;

namespace SortingHat
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            SortingHat sortingHat = new SortingHat();
            Console.WriteLine("Mmmm... differcult. Very differcult");
            Thread.Sleep(2000);
            Console.WriteLine("Where to put you?");
            Thread.Sleep(2000);
            Console.WriteLine("Ha now I know just what to do with you!");
            Thread.Sleep(2000);
            Console.WriteLine("{0}!", sortingHat._Groups);
        }
    }
}