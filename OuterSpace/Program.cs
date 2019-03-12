using System;
using System.Collections.Generic;

namespace OuterSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> spaceships = new List<string>() { "Soul Plane", "Destroyer", "Almighty" };
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");
            List<string> rockyPlanets = new List<string>(planetList.GetRange(0, 4).ToArray());

            var spaceshipHasVisited = new Dictionary<string, List<string>>
            {
                {"Ship Names", spaceships}
            };

            //foreach (var (spacename, planets) in spaceshipHasVisited)
            //{
            //    foreach (var planet in planets)
            //    {
            //        Console.WriteLine($"{planet}: {spacename}");
            //    }
            //}
            foreach (var planet in planetList)
            {
                Console.WriteLine($"{planet}:");
                foreach (var ship in spaceships)
                {
                    Console.WriteLine(ship);
                }
            }

            //foreach (var planet in rockyPlanets)
            //{
            //    Console.WriteLine(planet);
            //}
            Console.ReadLine();
        }
    }
}
