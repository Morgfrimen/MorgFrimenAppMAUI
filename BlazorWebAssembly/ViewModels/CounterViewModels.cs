
using System.Windows.Input;

using BlazorWebAssembly.Command;
using BlazorWebAssembly.ViewModels.Adstract;

namespace BlazorWebAssembly.ViewModels;

public sealed class CounterViewModels : BaceViewModels, ICounterViewModels
{
	public CounterViewModels()
	{
		IncrementCommand = new RelayCommand((obj) => Couters += 10);
	}

	private int _couters;

	public int Couters
	{
		get => _couters; set
		{
			_couters = value;
			base.OnPropertyChanged(nameof(Couters));
		}
	}

	public ICommand IncrementCommand { get; }
}
