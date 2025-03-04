using ArmoryInventory.App.ViewModels;
using ArmoryInventory.App.Views;
using ArmoryInventory.Data;
using ArmoryInventory.Data.Interfaces;
using ArmoryInventory.Data.Repositories;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using ArmoryInventory.App.Views.Popups;

namespace ArmoryInventory.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
            //Dependency Injections//
            //Repository
            builder.Services.AddSingleton<IRepository, SQLiteRepository>();
            //Dbcontext
            builder.Services.AddDbContext<ArmoryInventoryDbContext>();
            //Pages
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<AddItemPage>();
            builder.Services.AddTransient<ViewItemPage>();
            builder.Services.AddTransient<AddCheckoutPage>();
            //Popups
            builder.Services.AddTransientPopup<AddDefectPopup, AddDefectPopupViewModel>();
            builder.Services.AddTransientPopup<AddMissingComponentPopup, AddMissingComponentPopupViewModel>();
            //View Models
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<ItemViewModel>();
            builder.Services.AddTransient<AddCheckoutViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}