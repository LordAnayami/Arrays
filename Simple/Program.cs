using System;
using System.Collections.Generic;

namespace Simple
{
    class Program
    {
		
			static void Main(string[] args)
			{
				BusStop busStop = new BusStop();
				Bus bus = new Bus();

				for (int i = 0; i < 6; i++)
					busStop.PersonArrive(PassengerGenerator.CreatePassenger());

				busStop.BusArrive(bus);

				bus.ArriveAtTerminus();
			}
		}
	}

