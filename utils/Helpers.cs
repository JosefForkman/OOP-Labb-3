public static class Helpers
{
    public static string Ask(string question)
    {
        Console.WriteLine(question);
        return Console.ReadLine() ?? "";
    }
}
