using ArmoryInventory.App.ViewModels;
using ArmoryInventory.App.Views.Popups;
using CommunityToolkit.Maui.Views;

namespace ArmoryInventory.App.Views;

[QueryProperty(nameof(ItemId), "Id")]
public partial class AddCheckoutPage : ContentPage
{
    private readonly AddCheckoutViewModel addCheckoutViewModel;

    public string ItemId
    {
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                LoadPage(value);
            }
        }
    }

    public AddCheckoutPage(AddCheckoutViewModel chekoutViewModel)
	{
		InitializeComponent();
        this.BindingContext = this.addCheckoutViewModel = chekoutViewModel;
    }

    private async void LoadPage(string itemId)
    {
        await this.addCheckoutViewModel.LoadPageAsync(itemId);
    }
}