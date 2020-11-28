public class Rectangle : Shape
{
  private double a;
  private double b;
  public Rectangle(double a, double b)
  {
    if (a < 0) throw new System.ArgumentException();
    if (b < 0) throw new System.ArgumentException();

    this.a = a;
    this.b = b;
  }

  public new string ShapeType => "Rectangle";
  public new double Area => this.a * this.b;
  public new double Perimeter => (this.a + this.b) * 2;
}