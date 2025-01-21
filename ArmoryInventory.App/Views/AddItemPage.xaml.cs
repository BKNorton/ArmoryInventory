using ArmoryInventory.App.ViewModels;

namespace ArmoryInventory.App.Views;

public partial class AddItemPage : ContentPage
{
    private readonly ItemViewModel itemViewModel;

    public AddItemPage(ItemViewModel itemViewModel)
    {
        InitializeComponent();
        this.itemViewModel = itemViewModel;
        this.BindingContext = itemViewModel;
    }
}