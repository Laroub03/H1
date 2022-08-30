using System.Drawing;
using System.Globalization;

namespace RobotsComing
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Robot robot = new Robot();
            string[] WIFI = { "The Robot does not have WIFI", "The Robot does have WIFI", };
            Random random = new Random();
            int randomIndex = random.Next(2);
            string selectedWifi = WIFI[randomIndex];

            Console.WriteLine(selectedWifi);
            Console.WriteLine("The model name of the microchip is {0}", robot._Microchips);
            Console.WriteLine("The color of the robot is {0}", robot._Color);
            Random random1 = new Random();
            int soap = random1.Next(0,2);
            if (soap == 1)
            {
                Console.WriteLine("The robot contains {0}ml soap", robot._Soap);
            }
            else if (robot._Color == "White")
            {
                
            }
            else
            {
                Console.WriteLine("The capacity of the battery is {0}", robot._Battery);
            }
            Console.WriteLine("\nEnter the amount of wheels the robot has");
            robot.Wheels();
        }
    }
}