namespace Shapes.Models
{
  public class Triangle
  {
    public int Height { get; set; }
    public int TriBase { get; set; }
    public Triangle(int height, int triBase)
    {
      Height = height;
      TriBase = triBase;
    }
    public double GetArea()
    {
      return 0;
    }
  }
}