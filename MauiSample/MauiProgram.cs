﻿namespace MauiSample;

using MauiSample.Core.Facade;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddSingleton<IProductService, ProductService>();
		builder.Services.AddSingleton<IMainPageViewModel, MainPageViewModel>();

		return builder.Build();
	}
}
