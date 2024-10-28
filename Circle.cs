class Circle(double radius) : Geometry
{
    public double Radius { get; set; } = radius;
    public override double Area()
    {
        return Math.Pow(Math.PI, 2) * Radius;
    }
}