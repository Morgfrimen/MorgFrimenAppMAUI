using Foundation;

using Microsoft.Maui;

namespace MorgFrimenApp
{
	[Register(nameof(AppDelegate))]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp()
		{
			return MauiProgram.CreateMauiApp();
		}
	}
}