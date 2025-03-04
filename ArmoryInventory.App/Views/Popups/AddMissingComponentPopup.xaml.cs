using ArmoryInventory.App.ViewModels;
using CommunityToolkit.Maui.Views;

namespace ArmoryInventory.App.Views.Popups;

public partial class AddMissingComponentPopup : Popup
{
	public AddMissingComponentPopup(AddMissingComponentPopupViewModel viewModel)
	{
        InitializeComponent();
		BindingContext = viewModel;
	}
}