using System;

namespace Lab
{
  class Triangle: Shape {
    public static int count=0;
    private double side1;
    private double side2;
    private double side3;
    public double Side1 {
      get => side1;
      set => side1 = value;
    }
    public double Side2 {
      get => side2;
      set => side2 = value;
    }
    public double Side3 {
      get => side3;
      set => side3 = value;
    }
    public Triangle(double side1, double side2, double side3) {
      this.side1 = side1;
      this.side2 = side2;
      this.side3 = side3;
      count++;
      this.serial = count;
    }
    public override double Perimeter() => side1+side2+side3;
    public override double Area() {
      double s = this.Perimeter()/2;
      return Math.Sqrt(s*(s-side1)*(s-side2)*(s-side3));
    }
    public override void ShowDetails() {
      Console.WriteLine($"Statistics for Triangle {serial:00}:");
      Console.WriteLine($"Area      : {Area():f2}");
      Console.WriteLine($"Perimeter : {Perimeter():f2}");
    }
  }
}