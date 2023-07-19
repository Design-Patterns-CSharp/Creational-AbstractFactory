using AbstractFactory.Themes;
using AbstractFactory.Buttons;
using AbstractFactory.Toolbars;

namespace AbstractFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FactoryProvider factoryProvider = new FactoryProvider();
			IThemeAbstractFactory themeAbstractFactory = factoryProvider.GetFactory(ThemeType.Light);

			IButton button = themeAbstractFactory.GetButton();
			IToolbar toolbar = themeAbstractFactory.GetToolbar();

			button.Show();
			toolbar.Show();
		}
	}
}

/*
 * یک لایه بالاتر از الگوی
 * Factory
 * یعنی در این الگو٬ ما کارخانه ای داریم که
 * کارخانه های دیگر را برای ما میسازد
 * برای مثال در این پروژه هدف از استفاده از این
 * الگو این بوده که با انتخاب تم مورد نظر همه موجودیت هایی که
 * باید باهم تغییر داده شوند٬ یکجا اعمال گردند.
 * پس ما کارخانه ای برای ساخت تم
 * و کارخانه ای درون تم ها برای ساخت موجودیت های وابسته به نوع تم داریم
 */