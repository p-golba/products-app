using Microsoft.Extensions.Logging;
using ProductsApp.Services;
using ProductsApp.View;
using ProductsApp.ViewModel;
using Refit;

namespace ProductsApp;

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

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<AddProduct>();
        builder.Services.AddSingleton<EditProduct>();
        builder.Services.AddSingleton<ProductsList>();
        builder.Services.AddTransient<ProductViewModel>();
        builder.Services.AddTransient<ProductsListViewModel>();
        builder.Services.AddTransient<EditProductViewModel>();
        builder.Services.AddRefitClient<IProductsService>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("http://10.0.2.2:5000/api");
                c.Timeout = TimeSpan.FromSeconds(10);
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}