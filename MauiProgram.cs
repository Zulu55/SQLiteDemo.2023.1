using Microsoft.Extensions.Logging;
using SQLiteDemo.MVVM.Models;
using SQLiteDemo.Repository;

namespace SQLiteDemo;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<BaseRepository<Customer>>();
		builder.Services.AddSingleton<BaseRepository<Order>>();
		return builder.Build();
	}
}
