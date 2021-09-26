using System.ComponentModel;
using System.Runtime.CompilerServices;

using Microsoft.AspNetCore.Components;

namespace BlazorWebAssembly.ViewModels.Adstract
{
	public abstract class BaceViewModels : ComponentBase, INotifyPropertyChanged, IDisposable
	{
		public BaceViewModels()
		{
			PropertyChanged+=async (sender,e) => await InvokeAsync(() =>
			{
				StateHasChanged();
			});
		}
		
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
