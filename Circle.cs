public class Circle : Shape
{
  private double rad;
  public Circle(double rad)
  {
    if (rad < 0) throw new System.ArgumentException();
    this.rad = rad;
  }

  public new string ShapeType => "Circle";
  public new double Area => System.Math.PI * this.rad * this.rad;
  public new double Perimeter => 2 * System.Math.PI * this.rad;
  public double Diameter => 2 * this.rad;
}