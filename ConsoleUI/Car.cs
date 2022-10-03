using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving on four wheels.");
        }
        public string Seats;
        public string FrontDrive;
    }
}
