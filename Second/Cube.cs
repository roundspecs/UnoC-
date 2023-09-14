
using System;

namespace Lab
{
  class Cube: Shape {
    public static int count=0;
    private double side;
    public double Side {
      get => side;
      set => side = value;
    }
    public Cube(double side) {
      this.side = side;
      count++;
      this.serial = count;
    }
    public override double Perimeter() => 12*side;
    public override double Area() => 6*side*side;
    public double Volume() => side*side*side;
    public override void ShowDetails() {
      Console.WriteLine($"Statistics for Cube {serial:00}:");
      Console.WriteLine($"Area      : {Area():f2}");
      Console.WriteLine($"Perimeter : {Perimeter():f2}");
      Console.WriteLine($"Volume    : {Volume():f2}");
    }
  }
}