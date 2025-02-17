using ArmoryInventory.App.ViewModels;

namespace ArmoryInventory.App.Views;

[QueryProperty(nameof(ItemId), "Id")]
public partial class EditItemPage : ContentPage
{
    private readonly ItemViewModel itemViewModel;


    //Loading selected Item from IventoryMainPage
    public string ItemId
    {
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                LoadItem(value);
            }
        }
    }

    public EditItemPage(ItemViewModel itemViewModel)
    {
        InitializeComponent();
        this.itemViewModel = itemViewModel;
        this.BindingContext = itemViewModel;
    }

    private async void LoadItem(string itemId)
    {
        await this.itemViewModel.LoadItem(itemId);
    }
}