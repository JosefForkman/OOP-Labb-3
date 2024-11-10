namespace OPP_Labb_3.Menu;
public class MenuDisplay(Item[] options)
{
    public Item[] Options { get; set; } = options;
    private int SelectedOption = 0;

    // public int Show()
    // {
    //     bool isSelected = false;
    //     Console.WriteLine("Press arrow up and down to navigate. Select with enter");
    //     (int Left, int Top) = Console.GetCursorPosition();

    //     while (!isSelected)
    //     {
    //         for (int i = 0; i < Options.Length; i++)
    //         {
    //             Console.SetCursorPosition(Left, Top + i);
    //             var Option = Options[i];
    //             Console.WriteLine(SelectedOption == i ? $"\u001b[32m{Option}\u001b[0m" : Option);
    //         }
    //         var Key = Console.ReadKey().Key;

    //         switch (Key)
    //         {
    //             case ConsoleKey.UpArrow:
    //                 SelectedOption = SelectedOption <= 0 ? Options.Length - 1 : SelectedOption - 1;

    //                 break;
    //             case ConsoleKey.DownArrow:
    //                 SelectedOption = SelectedOption < Options.Length - 1 ? SelectedOption = SelectedOption + 1 : SelectedOption = 0;
    //                 break;
    //             case ConsoleKey.Enter:
    //                 isSelected = true;
    //                 break;
    //         }
    //     }
    //     return SelectedOption;
    // }
    public int Show()
    {
        bool isSelected = false;
        Console.WriteLine("Press arrow left and right to navigate. Select with enter");
        (int Left, int Top) = Console.GetCursorPosition();

        while (!isSelected)
        {

            string menuBar = "";
            for (int i = 0; i < Options.Length; i++)
            {
                Console.ResetColor();
                var Option = Options[i].Name;
                if (SelectedOption == i)
                {
                    menuBar += "\u001b[32m" + $" {Option} " + "\u001b[0m ";
                }
                else
                {
                    menuBar += $" {Option} ";
                }
            }
            // for (int i = 0; i < Options.Length; i++)
            // {
            //     var Option = Options[i].Name;
            //     menuBar += SelectedOption == i ? $" \u001b[32m{Option}\u001b[0m " : $" {Option} ";
            // }

            Console.SetCursorPosition(Left, Top);
            Console.WriteLine(menuBar.Trim());

            var Key = Console.ReadKey().Key;
            switch (Key)
            {
                case ConsoleKey.LeftArrow:
                    SelectedOption = SelectedOption <= 0 ? Options.Length - 1 : SelectedOption - 1;
                    break;
                case ConsoleKey.RightArrow:
                    SelectedOption = SelectedOption < Options.Length - 1 ? SelectedOption = SelectedOption + 1 : SelectedOption = 0;
                    break;
                case ConsoleKey.Enter:
                    isSelected = true;
                    break;
            }
        }
        return SelectedOption;
    }
}
