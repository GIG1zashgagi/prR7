using System;
using System.Collections.Generic;

namespace GalaxiesDebugDemo
{
    public class Galaxy
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double DistanceLightYears { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Type}) - {DistanceLightYears} св. лет";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каталог галактик\n");

            List<Galaxy> galaxies = CreateGalaxyList();

            DisplayGalaxiesFixed(galaxies);

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        static List<Galaxy> CreateGalaxyList()
        {
            return new List<Galaxy>
            {
                new Galaxy { Name = "Млечный Путь", Type = "Спиральная", DistanceLightYears = 0 },
                new Galaxy { Name = "Андромеда", Type = "Спиральная", DistanceLightYears = 2537000 },
                null, 
                new Galaxy { Name = "Галактика Водоворот", Type = "Спиральная", DistanceLightYears = 23000000 },
                new Galaxy { Name = "Sombrero", Type = "Спиральная", DistanceLightYears = 29000000 },
                null 
            };
        }
    }
}