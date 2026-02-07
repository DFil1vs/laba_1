using System;
using labi;
class Program {

        static void Main()
        {
            Koord lat1 = new Koord(55, 45, 'N');
            Koord lon1 = new Koord(37, 37, 'E');

            Koord lat2 = new Koord(59, 56, 'N');
            Koord lon2 = new Koord(30, 18, 'E');

            double distance = Koord.Distance(lat1, lon1, lat2, lon2);

            Console.WriteLine($"Расстояние: {distance:F2} км");
        }
    }



