using System;
using VehicleClassHierarchy;

class Program
{
    static void Main()
    {

        Car myCar = new Car("Toyota", "Fortuner", 2023, "Black", 4, "Desial");
        Console.WriteLine("Car:");
        myCar.Start();
        myCar.Stop();
        Console.WriteLine($"Number of Doors: {myCar.NumberOfDoors}, Fuel Type: {myCar.FuelType}");


        Bicycle myBicycle = new Bicycle("Trek", "Mountain Bike", 2022, "Black", 21, "Aluminum");
        Console.WriteLine("\nBicycle:");
        myBicycle.Start();
        myBicycle.Stop();
        Console.WriteLine($"Number of Gears: {myBicycle.NumberOfGears}, Frame Material: {myBicycle.FrameMaterial}");


        Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2023, "Red", "V-Twin");
        Console.WriteLine("\nMotorcycle:");
        myMotorcycle.Start();
        myMotorcycle.Stop();
        Console.WriteLine($"Engine Type: {myMotorcycle.EngineType}");






        Car myCar2 = new Car("Toyota", "Camry", 2023, "Blue", 4, "Gasoline");
        Bicycle myBicycle2 = new Bicycle("Trek", "Streat Fighter", 2023, "Red", 18, "Aluminum");
        Motorcycle myMotorcycle2 = new Motorcycle("Harley-Davidson", "Monster", 2023, "Black", "V-Twin");

        VehicleOperations[] vo = new VehicleOperations[] { myCar2, myBicycle2,myMotorcycle2 };

        foreach(VehicleOperations vehicle in vo)
        {
            Console.WriteLine( "Vehicle Type : " +vehicle.GetType);
            Console.WriteLine(vehicle.StartEngine);
            Console.WriteLine(vehicle.CalculateFuelEfficiency);
        }
    }
}
