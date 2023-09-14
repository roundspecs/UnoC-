using System;

namespace Lab
{
  class Circle: Shape {
    public static int count=0;
    public static double PI = 3.1415;
    private double radius;
    public double Radius {
      get => radius;
      set => radius = value;
    }
    public Circle(double radius) {
      this.radius = radius;
      count++;
      this.serial = count;
    }
    public Circle.takeInput() {
      Console.Write("Enter radius: ");
      this.radius = Convert.ToDouble(Console.ReadLine());
      count++;
      this.serial = count;
    }
    public override double Area() => PI*radius*radius;
    public override double Perimeter() => 2*PI*radius;
    public double Diameter() => 2*radius;
    public override void ShowDetails() {
      Console.WriteLine($"Statistics for Circle {serial:00}:");
      Console.WriteLine($"Area      : {Area():f2}");
      Console.WriteLine($"Perimeter : {Perimeter():f2}");
      Console.WriteLine($"Diameter  : {Diameter():f2}");
    }
  }
}