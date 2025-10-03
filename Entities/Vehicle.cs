using System;
using System.Collections.Generic;
using System.Linq;
namespace Course1.Entities
{
    internal class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
