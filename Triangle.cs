using System;

public class Triangle : Shape
{
  private double side;
  public Triangle(double side)
  {
    if (side < 0) throw new System.ArgumentException();
    this.side = side;
  }

  public new string ShapeType => "Triangle";
  public new double Area => this.side * this.side * Math.Sqrt(3) / 4;
  public new double Perimeter => this.side * 3;
}