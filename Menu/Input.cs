namespace OPP_Labb_3.Menu;

public class Input(int x = 0, int y = 0)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public int Width { get; set; } = 12;
    public string? Value { get; set; }
    public void Show()
    {
        string inputBox = "╔═════════╗\n" +
                          "║         ║\n" +
                          "╚═════════╝";
        Console.SetCursorPosition(X, Y);
        while (true)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 12; column++)
                {
                    Console.WriteLine(inputBox);
                }
            }
        }
    }
}
