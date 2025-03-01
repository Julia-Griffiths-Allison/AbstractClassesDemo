﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            Motorcycle bike1 = new Motorcycle() {Year = "2023", Make = "Suzuki", Modle = "GSX-R1000", SideCar = "No side car", Wheels = "Two wheels"};
            vehicles.Add(bike1);

            Car car1 = new Car() {Year = "2017", Make = "Ford", Modle = "Focus", Seats = "Five seats", FrontDrive = "This car is front wheel drive" };


            Vehicle bike2 = new Motorcycle() { Year = "2023", Make = "Honda", Modle = "Gold Wing", SideCar = "No side car", Wheels = "Two wheels" };


            Vehicle car2 = new Car() { Year = "1999", Make = "Chevy", Modle = "Malubi", Seats = "Five seats", FrontDrive = "This car is front wheel drive" };



            #region Vehicles
            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
            // Create a list of Vehicle called vehicles
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            // Call each of the drive methods for one car and one motorcycle
            #endregion            
        }
    }
}
