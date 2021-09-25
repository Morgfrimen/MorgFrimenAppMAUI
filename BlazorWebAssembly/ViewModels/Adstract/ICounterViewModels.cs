using System.Windows.Input;

namespace BlazorWebAssembly.ViewModels.Adstract;

public interface ICounterViewModels
{
	public int Couters { get; set; }

	public ICommand IncrementCommand{get;}
}
