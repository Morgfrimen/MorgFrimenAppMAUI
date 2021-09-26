using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorWebAssembly.ViewModels.Adstract
{
	public abstract class BaceViewModels : INotifyPropertyChanged, IDisposable
	{
		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void Dispose()
		{
			PropertyChanged = null;
		}
	}
}
