using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving the hog.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("No avalibile self-driving bikes");
        }
        public string SideCar;
        public string Wheels;
    }
}
