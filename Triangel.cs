class Triangel : Geometry
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Triangel()
    {
        Height = 5;
        Width = 10;
    }

    public Triangel(int height, int width)
    {
        if (Validation.ValidateHeightWidthIsLessThenZero(height, width))
        {
            throw new ArgumentException("width and height can not be negative or 0");
        }

        Height = height;
        Width = width;
    }

    public override double Area()
    {
        return Height * Width / 2;
    }

    public override double Circumference()
    {
        return Height + Width + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
    }
}