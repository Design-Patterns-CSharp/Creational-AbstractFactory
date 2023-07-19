using AbstractFactory.Buttons;
using AbstractFactory.Toolbars;

namespace AbstractFactory.Themes;

public class LightThemeFactory : IThemeAbstractFactory
{
	public IButton GetButton()
	{
		return new LightButton();
	}

	public IToolbar GetToolbar()
	{
		return new LightToolbar();
	}
}