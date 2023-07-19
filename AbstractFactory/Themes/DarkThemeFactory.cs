using AbstractFactory.Buttons;
using AbstractFactory.Toolbars;

namespace AbstractFactory.Themes;

public class DarkThemeFactory : IThemeAbstractFactory
{
	public IButton GetButton()
	{
		return new DarkButton();
	}

	public IToolbar GetToolbar()
	{
		return new DarkToolbar();
	}
}