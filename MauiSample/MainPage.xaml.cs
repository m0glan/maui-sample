namespace MauiSample;

public partial class MainPage : ContentPage
{
	private readonly MauiApp _app;

	public MainPage()
	{
		InitializeComponent();
		_app = MauiProgram.CreateMauiApp();
		BindingContext = _app.Services.GetService<IMainPageViewModel>();
	}
}

