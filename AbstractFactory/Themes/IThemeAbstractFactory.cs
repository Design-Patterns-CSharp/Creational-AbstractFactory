using AbstractFactory.Buttons;
using AbstractFactory.Toolbars;

namespace AbstractFactory.Themes;

public interface IThemeAbstractFactory
{
	IToolbar GetToolbar();
	IButton GetButton();
}