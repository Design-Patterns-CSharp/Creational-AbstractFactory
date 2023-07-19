using AbstractFactory.Themes;

namespace AbstractFactory;

public class FactoryProvider
{
	public IThemeAbstractFactory GetFactory(ThemeType type)
	{
		IThemeAbstractFactory factory;

		switch (type)
		{
			case ThemeType.Dark:
				factory = new DarkThemeFactory();
				break;
			case ThemeType.Light:
				factory = new LightThemeFactory();
				break;
			default:
				factory = new LightThemeFactory();
				break;
		}

		return factory;
	}
}