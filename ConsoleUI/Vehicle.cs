using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I have a mechanical driver!");
        }
            public string Year;
            public string Modle;
            public string Make;
    }
}
