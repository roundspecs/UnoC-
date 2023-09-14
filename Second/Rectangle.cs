using System;

namespace Lab
{
  class Rectangle: Shape {
    public static int count=0;
    private double width;
    private double height;
    public double Width {
      get => width;
      set => width = value;
    }
    public double Height {
      get => height;
      set => height = value;
    }
    public Rectangle(double width, double height) {
      this.width = width;
      this.height = height;
      count++;
      this.serial = count;
    }
    public Rectangle.takeInput() {
      Console.Write("Enter width: ");
      this.width = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter height: ");
      this.height = Convert.ToDouble(Console.ReadLine());
      count++;
      this.serial = count;
    }
    public override double Area() => width*height;
    public override double Perimeter() => 2*(width+height);
    public double Diagonal() => Math.Sqrt(height*height+width*width);
    public string AspectRatio() => $"{height}x{width}";
    public override void ShowDetails() {
      Console.WriteLine($"Statistics for Rectangle {serial:00}:");
      Console.WriteLine($"Area      : {Area():f2}");
      Console.WriteLine($"Perimeter : {Perimeter():f2}");
      Console.WriteLine($"Diagonal  : {Diagonal():f2}");
      Console.WriteLine($"Aspect    : {AspectRatio()}");
    }
  }
}