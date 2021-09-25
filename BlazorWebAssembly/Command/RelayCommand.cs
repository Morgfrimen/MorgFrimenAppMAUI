using System.Windows.Input;

namespace BlazorWebAssembly.Command
{
	public sealed class RelayCommand   : ICommand
	{
	private readonly Action<object> _execute;
	private readonly Func<object,bool>? _executeCan;

		public RelayCommand(Action<object> execute, Func<object, bool>? executeCan = null)
		{
			_execute = execute;
			_executeCan = executeCan;
		}

		public bool CanExecute(object? parameter)
		{
			return _executeCan!.Invoke(parameter!);
		}

		public void Execute(object? parameter)
		{
			_execute!.Invoke(parameter!);
		}

		public event EventHandler? CanExecuteChanged;
	}
}
