namespace OPP_Labb_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle(5);
            Geometry square = new Square(5, 5);
            Geometry rectangle = new Rectangle(5, 10);
            Geometry triangel = new Triangel(5, 10);

            Geometry[] geometrys = [circle, square, rectangle, triangel];

            foreach (var geometry in geometrys)
            {
                Console.WriteLine($"Area of {geometry.GetType()}: {geometry.Area()}");
            }
        }
    }
}
