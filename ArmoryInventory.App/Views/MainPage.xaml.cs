using ArmoryInventory.App.ViewModels;

namespace ArmoryInventory.App.Views;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel mainViewModel;

    public MainPage(MainViewModel mainViewModel)
    {
        InitializeComponent();
        this.mainViewModel = mainViewModel;
        this.BindingContext = mainViewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Refresh the Inventory everytime you navigate back to mainpage so
        // that any changes that have been made are reflected
        await this.mainViewModel.ReFreshItemsAsync();
        this.Window.MinimumHeight = 800;
        this.Window.MinimumWidth = 1200;
    }
}