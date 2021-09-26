using BlazorWebAssembly.ViewModels.Adstract;

namespace BlazorWebAssembly.ViewModels
{
	public sealed class IndexViewModels : BaceViewModels, IIndexViewModels
	{
		private string? _title;

		public string? Title
		{
			get => _title; set
			{
				_title = value;
				base.OnPropertyChanged(nameof(Title));
			}
		}
	}
}
