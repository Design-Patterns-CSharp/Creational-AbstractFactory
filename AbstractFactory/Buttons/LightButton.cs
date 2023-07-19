namespace AbstractFactory.Buttons;

public class LightButton : IButton
{
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("LightButton");
    }
}