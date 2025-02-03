using ArmoryInventory.App.ViewModels;

namespace ArmoryInventory.App.Views;

[QueryProperty(nameof(ItemId), "Id")]
public partial class ViewItemPage : ContentPage
{
	private readonly ItemViewModel itemViewModel;

	public string ItemId
	{
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				LoadItem(value);
			}
		}
	}

	public ViewItemPage(ItemViewModel itemViewModel)
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