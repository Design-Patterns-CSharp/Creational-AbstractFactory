namespace AbstractFactory.Toolbars;

public class DarkToolbar : IToolbar
{
	public void Show()
	{
		Console.ForegroundColor = ConsoleColor.DarkMagenta;
		Console.WriteLine("DarkToolbar");
	}
}