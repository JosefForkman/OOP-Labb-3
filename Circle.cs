class Circle : Geometry
{
    public double Radius { get; set; }

    public Circle()
    {
        Radius = 5;
    }
    public Circle(double radius)
    {
        Radius = radius;
        if (Validation.ValidateRadiusIsLessThenZero(Radius))
        {
            throw new ArgumentException("Radius can not be negative or 0");
        }
    }
    public override double Area()
    {
        return Math.Pow(Math.PI, 2) * Radius;
    }

    public override double Circumference()
    {
        return 2 * (Math.PI * Radius);
    }
}