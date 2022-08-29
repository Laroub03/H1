using System.Globalization;

namespace ElonSatsning
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("The battery is at {0}%", car.Start());
            car.Color();
            Console.WriteLine("The color of the RC car is {0}", car._Color);
            while (car._Battery != 0)
            {
                Console.WriteLine("Enter the amount of meters the RC car have driven");
                car.Drive();
                Console.WriteLine("There is now {0}% battery left\n", car._Battery);
                if (car._Battery == 0)
                {
                    Console.WriteLine("The RC car ran out of battery. Please recharge!");
                }
            }

        }
    }
}