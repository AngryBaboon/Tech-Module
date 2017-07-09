using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Catalogue
{
    class Program
    {
        class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
        }

        static void Main(string[] args)
        {
            var classVehicle = new Vehicle();
            var vehicleList = new List<Vehicle>();

            while (true)
            {
                var input = Console.ReadLine().ToLower().Split();

                if (input[0] == "end") break;

                var type = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input[0]);
                var model = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input[1]);
                var color = input[2];
                var horsepower = int.Parse(input[3]);

                classVehicle = new Vehicle()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = horsepower
                };

                vehicleList.Add(classVehicle);
            }

            while (true)
            {
                var input = Console.ReadLine().ToLower();

                if (input == "close the catalogue") break;

                input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
                foreach (var vehicle in vehicleList)
                {
                    if (vehicle.Model.Contains(input))
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }
            }

            if (vehicleList.Where(x => x.Type == "Car").Count() > 0)
                Console.WriteLine($"Cars have average horsepower of: {vehicleList.Where(x => x.Type == "Car").Select(x => x.Horsepower).Average():F2}.");
            else
                Console.WriteLine($"Cars have average horsepower of: 0.00.");

            if (vehicleList.Where(x => x.Type == "Truck").Count() > 0)
                Console.WriteLine($"Trucks have average horsepower of: {vehicleList.Where(x => x.Type == "Truck").Select(x => x.Horsepower).Average():F2}.");
            else
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
        }
    }
}
