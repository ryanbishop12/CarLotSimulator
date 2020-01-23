using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot busters = new CarLot();
            Car gold = new Car();
            gold.Year = 2000;
            gold.Make = "Lexus";
            gold.Model = "GS300";
            gold.EngineNoise = "grrrrrr";
            gold.HonkNoise = "honk";
            gold.IsDriveable = false;
            busters.Cars.Add(gold);

            Car blue = new Car(2014, "Chevy", "Spark", "djjjjjj", "Donk", true);
            busters.Cars.Add(blue);

            Car mocha = new Car() { Year = 2020, Make = "Lexus", Model = "LS500", EngineNoise = "drrrrr", HonkNoise = "Honk", IsDriveable = true };
            busters.Cars.Add(mocha);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("Cars At Buster's Car Lot:");
            foreach(Car c in busters.Cars)
            {
                Console.WriteLine($"{c.Year} {c.Make} {c.Model}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
