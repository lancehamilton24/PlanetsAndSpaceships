using System;
using System.Collections.Generic;

namespace OuterSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");
            List<string> rockyPlanets = new List<string>(planetList.GetRange(0, 4).ToArray());

            var shipsThatVisitedMercury = new List<string>() { "Helios A", "Helios B" };
            var shipsThatVisitedMars = new List<string>() { "ISEE-3" };
            var shipsThatVisitedJupiter = new List<string>() { "WIND", "SOHO", "ACE" };
            var shipsThatVisitedSaturn = new List<string>() { "Sterio A", "Ulysses" };
            var shipsThatVisitedVenus = new List<string>() { "DSCVR" };
            var shipsThatVisitedUranus = new List<string>() { "Pioneer 7", "Pioneer 8", "Pioneer 9" };
            var shipsThatVisitedNeptune = new List<string>() { "Pioneer E" };

            var planetExploration = new Dictionary<string, List<string>>
            {
                {"Mercury", shipsThatVisitedMercury},
                {"Mars", shipsThatVisitedMars},
                {"Jupiter", shipsThatVisitedJupiter},
                {"Saturn", shipsThatVisitedSaturn},
                {"Venus", shipsThatVisitedVenus},
                {"Uranus", shipsThatVisitedUranus},
                {"Neptune", shipsThatVisitedNeptune}
            };

            foreach (var planet in planetList)
            {
                foreach (var (visitedPlanet, ships) in planetExploration)
                {
                    if(planet == visitedPlanet)
                    {
                        foreach (string value in ships)
                        Console.WriteLine($"{planet} was visited by: {value}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
