namespace AbstractFactory.Toolbars;

public class LightToolbar : IToolbar
{
	public void Show()
	{
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("LightToolbar");
	}
}