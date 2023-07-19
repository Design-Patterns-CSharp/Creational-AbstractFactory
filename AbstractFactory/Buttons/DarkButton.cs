namespace AbstractFactory.Buttons;

public class DarkButton : IButton
{
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("DarkButton");
    }
}