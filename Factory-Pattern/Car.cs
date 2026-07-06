using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving Car");
        }

    }
}