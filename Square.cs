class Square : Geometry
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Square()
    {
        Height = 5;
        Width = 5;
    }
    public Square(int height, int width)
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
        return Height * Width;
    }

    public override double Circumference()
    {
        return Height * 2 + Width * 2;
    }
}