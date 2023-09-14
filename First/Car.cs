using System;

namespace Salahin {
class Car
    {
        private string make;
        private string model;
        private int year;
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public void Start() => Console.WriteLine("The car is starting...");
        public void DisplayDetails() => Console.WriteLine($"Car Details: {make} {model} ({year})");
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}