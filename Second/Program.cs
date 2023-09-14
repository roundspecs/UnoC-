using System;
using System.Collections.Generic;

namespace Lab {
  class Driver {
    static void Main(string[] args) {
      List<Shape> shapes = new List<Shape> {
        new Circle(5),
        new Cube(9),
        new Rectangle(5,6),
        new Triangle(5,6,7),
        new Cube(5)
      };
      while(true) {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Add circle");
        Console.WriteLine("2. Add rectangle");
        Console.WriteLine("3. Add triangle");
        Console.WriteLine("4. Add cube");
        Console.WriteLine("5. Exit");
        int option = Conver.ToInt32(Console.ReadLine());
        if(option==1) {
          shapes.Add(Circle.takeInput());
        }
        else if(option==2) {
          shapes.Add(Rectangle.takeInput())
        }
        // else if(option==3) {
        //   shapes.Add(Triangle.takeInput());
        // }
        // else if(option==4) {
        //   shapes.Add(Cube.takeInput());
        // }
        else if(option==5){
          break;
        }
        else {
          Console.WriteLine("Invalid Input");
        }
      }
      foreach (var shape in shapes)
      {
        shape.ShowDetails();
        Console.WriteLine();
      }
    }
  }
}