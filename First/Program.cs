using System;
using Salahin;

class Program
{
        static void Main()
        {
            Car myCar = new Car("Toyota", "Corolla", 2022);
            myCar.Start();
            Console.WriteLine($"Original Make: {myCar.Make}");
            myCar.Make = "Honda";
            Console.WriteLine($"Updated Make: {myCar.Make}");
            Console.WriteLine($"Original Model: {myCar.Model}");
            myCar.Model = "Civic";
            Console.WriteLine($"Updated Model: {myCar.Model}");
            Console.WriteLine($"Original Year: {myCar.Year}");
            myCar.Year = 2023;
            Console.WriteLine($"Updated Year: {myCar.Year}");
            myCar.DisplayDetails();
        }
}