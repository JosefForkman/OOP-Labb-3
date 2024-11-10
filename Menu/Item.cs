using System;

namespace OPP_Labb_3.Menu;

public class Item
{
    public string Name { get; set; }
    public Input[] Inputs { get; set; }

    public Item(string name, Input[] inputs)
    {
        Name = name;
        Inputs = inputs;

        (int Left, int Top) = Console.GetCursorPosition();

        for (var i = 0; i < Inputs.Length; i++)
        {
            var Input = Inputs[i];
            Input.X = Left + Input.Width + 2;
        }
    }
}
