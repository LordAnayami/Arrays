using System;
using System.Collections.Generic;
using System.Text;

namespace SimulateJourney
{
    public class Passenger
    {
        public string name;
        public string destination;
        public string Name { get =>name; set => name = value; }
        public string Destination { get =>destination; set => destination = value; }
        public Passenger(string name, string destination)
        {
            this.Name = name;
            this.Destination = destination;
        }
        public override string ToString() => $"{Name} to {Destination}";
    }
}
