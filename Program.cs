using OPP_Labb_3.Menu;

namespace OPP_Labb_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Console.ForegroundColor = ConsoleColor.White;
            /* Polymorfism börjar använda här med att alla former har 
               ärver typen "Geometry". Det ser till att alla former 
               har samma metoder och inga specifika metoder eller 
               egenskaper finns.   
             */
            // Geometry circle = new Circle();
            // Geometry square = new Square();
            // Geometry rectangle = new Rectangle();
            // Geometry triangel = new Triangel();

            /* 
               Man kan se att man använder polymorfism här också 
               eftersom alla former får plats i en geometrys arrayen.
               Om inte till exempel circle skulle ärva Geometry 
               classen och göra override på Area och Circumference 
               metoderna så skulle Dotnet börja klaga.   
             */
            // List<Geometry> geometrys = [circle, square, rectangle, triangel];

            // geometrys.Sort((firstGeometry, secondGeometry) => firstGeometry.Area().CompareTo(secondGeometry.Area()));

            // foreach (var geometry in geometrys)
            // {
            //     Console.WriteLine($"Area of {geometry.GetType()}: {geometry.Area()}");
            //     Console.WriteLine($"Circumference of {geometry.GetType()}: {geometry.Circumference()}");
            //     Console.WriteLine("____________");
            // }
            var circleOption = new Item("circle", []);
            var squareOption = new Item("square", []);
            var rectangleOption = new Item("rectangle", []);
            var triangelOption = new Item("triangel", []);
            var exitOption = new Item("Exit", []);
            var menu = new MenuDisplay([circleOption, squareOption, rectangleOption, triangelOption, exitOption]);

            Console.Clear();
            while (true)
            {

                int selectedMenueItem = menu.Show();
                int radius;
                int width;
                int height;
                switch (selectedMenueItem)
                {
                    case 0:
                        while (!int.TryParse(Helpers.Ask("What is the radius on the circle"), out radius) || radius <= 0)
                        {
                            Console.WriteLine("radius need to be a number and more then 0");
                        }

                        Geometry circle = new Circle(radius);
                        Console.WriteLine($"Area of {circle.GetType()}: {circle.Area()}");
                        Console.WriteLine($"Circumference of {circle.GetType()}: {circle.Circumference()}");
                        break;
                    case 1:
                        while (!int.TryParse(Helpers.Ask("What is the width on the square"), out width) || width <= 0)
                        {
                            Console.WriteLine("Width need to be a number and more then 0");
                        }
                        Geometry square = new Square(width, width);
                        Console.WriteLine($"Area of {square.GetType()}: {square.Area()}");
                        Console.WriteLine($"Circumference of {square.GetType()}: {square.Circumference()}");
                        break;
                    case 2:
                        while (!int.TryParse(Helpers.Ask("What is the width on the rectangle"), out width) || width <= 0)
                        {
                            Console.WriteLine("Width need to be a number and more then 0");
                        }
                        while (!int.TryParse(Helpers.Ask("What is the height on the rectangle"), out height) || height == width || height <= 0)
                        {
                            Console.WriteLine("Height need to be a number, more then 0 and not the same as width");
                        }

                        Geometry rectangle = new Rectangle(height, width);
                        Console.WriteLine($"Area of {rectangle.GetType()}: {rectangle.Area()}");
                        Console.WriteLine($"Circumference of {rectangle.GetType()}: {rectangle.Circumference()}");
                        break;
                    case 3:
                        while (!int.TryParse(Helpers.Ask("What is the width on the rectangle"), out width) || width <= 0)
                        {
                            Console.WriteLine("Width need to be a number and more then 0");
                        }
                        while (!int.TryParse(Helpers.Ask("What is the height on the rectangle"), out height) || height <= 0)
                        {
                            Console.WriteLine("Width need to be a number and more then 0");
                        }

                        Geometry triangel = new Triangel(height, width);
                        Console.WriteLine($"Area of {triangel.GetType()}: {triangel.Area()}");
                        Console.WriteLine($"Circumference of {triangel.GetType()}: {triangel.Circumference()}");
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("You can't choose that");
                        break;
                }
            }
        }
    }
}
