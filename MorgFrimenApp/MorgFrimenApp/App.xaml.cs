
using Application = Microsoft.Maui.Controls.Application;

namespace MorgFrimenApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}
	}
}
