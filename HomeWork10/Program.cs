using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Town
    {
        public string name;
        public string nameOfRegion;
        public string nameOfCountry;
        public int population;
        public int postalCode;
        public int phoneCode;


        public void Information(string name, string nameOfRegion, string nameOfCountry, int population, int postalCode, int phoneCode)
        {

            this.name = name;
            Console.WriteLine($"Town: {name}");
            this.nameOfRegion = nameOfRegion;
            Console.WriteLine($"Region: {nameOfRegion}");
            this.nameOfCountry = nameOfCountry;
            Console.WriteLine($"Country: {nameOfCountry}");
            this.population = population;
            Console.WriteLine($"Population: {population}");
            this.postalCode = postalCode;
            Console.WriteLine($"Postal code: {postalCode}");
            this.phoneCode = phoneCode;
            Console.WriteLine($"Phone code: {phoneCode}");
        }

    }
    class Country
    {
        public string name;
        public string continent;
        public int population;
        public int phoneCode;
        public string capital;
        new List<string> cities;
        public void CountryInformation(string name, string continent, int population, int phoneCode, string capital, List<string> cities)
        {
            this.name = name;
            Console.WriteLine($"Country: {name}");
            this.continent = continent;
            Console.WriteLine($"Mainland: {continent}");
            this.population = population;
            Console.WriteLine($"Population: {population}");
            this.phoneCode = phoneCode;
            Console.WriteLine($"Phone code: {phoneCode}");
            this.capital = capital;
            Console.WriteLine($"Capital: {capital}");
            this.cities = cities;
            Console.Write("Cities:");
            foreach (string city in cities) 
            {
                Console.Write($" {city},");
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter 1 or 2 to select a task");
            int task = Convert.ToInt32(Console.ReadLine());
            if (task == 1)
            {
                var town = new Town();
                Console.WriteLine("Enter 1 to see information about your town.\nEnter 2 to see information about Kyiv.\nEnter 3 to see information about Tokyo.");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Write name of your town");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write name of region of your town");
                    string nameOfRegion = Console.ReadLine();
                    Console.WriteLine("Write name of the country");
                    string nameOfCountry = Console.ReadLine();
                    Console.WriteLine("Write number of population");
                    int population = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write postal code of your town");
                    int postalCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write phone code of your town");
                    int phoneCode = Convert.ToInt32(Console.ReadLine());

                    town.Information(name, nameOfRegion, nameOfCountry, population, postalCode, phoneCode);
                }
                else if (number == 2)
                {
                    string name = "Kyiv";
                    string nameOfRegion = "Kyiv Oblast";
                    string nameOfCountry = "Ukraine";
                    int population = 2952301;
                    int postalCode = 01001;
                    int phoneCode = 44;
                    town.Information(name, nameOfRegion, nameOfCountry, population, postalCode, phoneCode);
                }
                else if (number == 3)
                {
                    string name = "Tokyo";
                    string nameOfRegion = "Kantō";
                    string nameOfCountry = "Japan";
                    int population = 14094034;
                    int postalCode = 1000000;
                    int phoneCode = 813;
                    town.Information(name, nameOfRegion, nameOfCountry, population, postalCode, phoneCode);
                }
                else throw new Exception();
            }

            else if (task == 2)
            {
                var country = new Country();
                Console.WriteLine("Enter 1 to see information about your country.\nEnter 2 to see information about Ukraine.\nEnter 3 to see information about Japan.");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Write name of your country");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write name of continent");
                    string continent = Console.ReadLine();
                    Console.WriteLine("Write number of population");
                    int population = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write phone code of your country");
                    int phoneCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write capital of you country");
                    string capital = Console.ReadLine();
                    Console.WriteLine("Write names of 3 cities");
                    List<string> cities = new List<string>();
                    int loop = 0;
                    while (loop < 3)
                    {
                        string city = Console.ReadLine();
                        cities.Add(city);
                        loop++;
                    }

                    country.CountryInformation(name, continent, population, phoneCode, capital, cities);
                }
                else if (number == 2)
                {
                    string name = "Ukraine";
                    string continent = "Eurasia";
                    int population = 33365000;
                    int phoneCode = 380;
                    string capital = "Kyiv";
                    List<string> cities = new List<string> { "Kyiv", "Odesa", "Lviv" };
                    country.CountryInformation(name, continent, population, phoneCode, capital, cities);
                }
                else if (number == 3)
                {
                    string name = "Japan";
                    string continent = "Eurasia";
                    int population = 123970000;
                    int phoneCode = 81;
                    string capital = "Tokyo";
                    List<string> cities = new List<string> { "Kyoto", "Tokyo", "Osaka" };
                    country.CountryInformation(name, continent, population, phoneCode, capital, cities);
                }

                else throw new Exception();
            }
            else throw new Exception();
        }
    }
}
