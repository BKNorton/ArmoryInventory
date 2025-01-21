using ArmoryInventory.App.Interfaces;
using ArmoryInventory.App.Repositories;
using ArmoryInventory.App.ViewModels;
using ArmoryInventory.App.Views;
using Microsoft.Extensions.Logging;

namespace ArmoryInventory.App
{
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

            //Dependency Injections//

            //Repository
            builder.Services.AddSingleton<IRepository, InMemoryRepository>();

            //Pages
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<AddItemPage>();
            builder.Services.AddTransient<EditItemPage>();

            //View Models
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<ItemViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
