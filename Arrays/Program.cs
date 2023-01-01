//using System;

//namespace Arrays
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
//            BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

//            //BusRoute[] routes =
//            //{
//            //    route40,
//            //    route42,
//            //    new BusRoute(100, "University", "Morecambe"),
//            //    new BusRoute(555, "Lancaster", "Keswick")
//            //};

//            BusRoute[] routes = new BusRoute[4];
//            routes[0] = route40;
//            routes[1] = route42;
//            routes[2] = new BusRoute(100, "University", "Morecambe");
//            routes[3] = new BusRoute(555, "Lancaster", "Keswick");

//            //foreach (BusRoute route in routes) 
//            //     Console.WriteLine(route);

//            for (int i = 0; i < routes.Length; i++)
//                Console.WriteLine(routes[i]);

//            BusRoute firstRoute = routes[0];
//            Console.WriteLine($"The third route is {routes[2]}");
//            BusRoute lastRoute = routes[^1]; // = długość -1 
//            Console.WriteLine($"The last route is {lastRoute}");


//        }
//    }
//}
