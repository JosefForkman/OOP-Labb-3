class Rectangle(int height, int width) : Geometry
{
    public int Height { get; set; } = height;
    public int Width { get; set; } = width;
    public override double Area()
    {
        return Height * Width;
    }
}