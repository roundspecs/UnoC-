using System;

namespace Lab
{
  abstract class Shape {
    public int serial;
    public abstract double Area();
    public abstract double Perimeter();
    public abstract void ShowDetails();
  }
}