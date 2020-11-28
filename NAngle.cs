public class NAngle : Shape
{
  private double side;
  private int count;
  public NAngle(double side, int count)
  {
    if (side < 0) throw new System.ArgumentException();
    if (count < 3) throw new System.ArgumentException();
    this.side = side;
    this.count = count;
  }

  public new string ShapeType => "NAngle";
  public new double Area => this.side * this.side * this.count / 4 / System.Math.Tan(System.Math.PI / this.count);
  public new double Perimeter => this.count * this.side;
}