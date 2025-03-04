using ArmoryInventory.App.ViewModels;
using CommunityToolkit.Maui.Views;
using System.Runtime.CompilerServices;

namespace ArmoryInventory.App.Views.Popups;

public partial class AddDefectPopup : Popup
{

    public AddDefectPopup(AddDefectPopupViewModel addDefectPopupViewModel)
	{
		InitializeComponent();
		BindingContext = addDefectPopupViewModel;
	}
}