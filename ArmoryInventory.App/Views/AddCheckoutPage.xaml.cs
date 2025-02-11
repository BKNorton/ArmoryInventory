using ArmoryInventory.App.ViewModels;

namespace ArmoryInventory.App.Views;

[QueryProperty(nameof(ItemId), "Id")]
public partial class AddCheckoutPage : ContentPage
{
    private readonly ItemViewModel itemViewModel;

    public string ItemId
    {
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                //LoadItem(value);
            }
        }
    }

    public AddCheckoutPage(ItemViewModel itemViewModel)
	{
		InitializeComponent();
        this.itemViewModel = itemViewModel;
        this.BindingContext = itemViewModel;
    }
}