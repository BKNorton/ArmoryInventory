using ArmoryInventory.App.Views;
using ArmoryInventory.Data.Interfaces;
using ArmoryInventory.Domain.Enums;
using ArmoryInventory.Domain.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Type = ArmoryInventory.Domain.Enums.Type;

namespace ArmoryInventory.App.ViewModels
{
    public partial class ItemViewModel : ObservableObject
    {
        private readonly IRepository repository;
        public ObservableCollection<Checkout> CheckoutHistory { get; set; }

        private Item item;
        public Item Item
        {
            get => item;
            set
            {
                SetProperty(ref item, value);
            }
        }

        private int itemTypeSelectedIndex;
        public int ItemTypeSelectedIndex
        {
            get => itemTypeSelectedIndex;
            set
            {
                SetProperty(ref itemTypeSelectedIndex, value);
            }
        }

        private int hasComponentsSelectedIndex;
        public int HasComponentsSelectedIndex
        {
            get => hasComponentsSelectedIndex;
            set
            {
                SetProperty(ref hasComponentsSelectedIndex, value);
            }
        }

        private int missionCapableSelectedIndex;
        public int MissionCapableSelectedIndex
        {
            get => missionCapableSelectedIndex;
            set
            {
                SetProperty(ref missionCapableSelectedIndex, value);
            }
        }

        private int checkedOutSelectedIndex;
        public int CheckedOutSelectedIndex
        {
            get => checkedOutSelectedIndex;
            set
            {
                SetProperty(ref checkedOutSelectedIndex, value);
            }
        }

        private string defects;
        public string Defects
        {
            get => defects;
            set
            {
                SetProperty(ref defects, value);
            }
        }

        private string missingComponents;
        public string MissingComponents
        {
            get => missingComponents;
            set
            {
                SetProperty(ref missingComponents, value);
            }
        }

        public List<string> ItemTypePicker
        {
            get => Enum.GetNames(typeof(Type)).ToList();
        }

        public List<string> TrueOrFalsePicker
        {
            get => Enum.GetNames(typeof(TrueOrFalse)).ToList();
        }

        public ItemViewModel(IRepository repository)
        {
            item = new Item();
            CheckoutHistory = [];
            defects = string.Empty;
            missingComponents = string.Empty;
            this.repository = repository;
        }

        /// <summary>
        /// itemId sent from the view to this viewModel uses the injected repository to grab the item and load it into the view model, so that any page using this view model 
        /// can display its information.
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public async Task LoadItemAsync(string itemId)
        {
            //Verification
            if (string.IsNullOrWhiteSpace(itemId)) return;
            Item = await repository.GetItemByIdAsync(itemId);
            if (Item is null || Item.Id == Guid.Empty) return;

            //Load properties
            var checkouts = Item.CheckoutHistory?.ToList();
            if (checkouts != null && checkouts.Count > 0)
            {
                for ( int i = 0; i < checkouts.Count; i++)
                {
                    CheckoutHistory.Add(checkouts[i]);
                }
            }


            ItemTypeSelectedIndex = (int)Item.ItemType;
            HasComponentsSelectedIndex = (int)Item.HasAllComponents;
            MissionCapableSelectedIndex = (int)Item.MissionCapable;
            CheckedOutSelectedIndex = (int)Item.CheckedOut;

            var defString = string.Empty;
            if (Item.Defects != null)
            {
                for (int i = 0; i < Item.Defects.Count; i++)
                {
                    defString += Item.Defects[i].Trim();

                    if (i < Item.Defects.Count - 1) defString += ", ";
                }
                Defects = defString;
            }

            var missString = string.Empty;
            if (Item.MissingComponents != null)
            {
                for (int i = 0; i < Item.MissingComponents.Count; i++)
                {
                    missString += Item.MissingComponents[i].Trim();

                    if (i < Item.MissingComponents.Count - 1) missString += ", ";
                }
                MissingComponents = missString;
            }
        }

        //ItemViewModel properties reflecting Picker properties used in Views to set ItemViewModel Item enum properties.
        private void SetItemPropsWithPickers()
        {
            if (Enum.TryParse(itemTypeSelectedIndex.ToString(), out Type typeValue))
            {
                Item.ItemType = typeValue;
            }

            if (Enum.TryParse(hasComponentsSelectedIndex.ToString(), out TrueOrFalse hasCompValue))
            {
                Item.HasAllComponents = hasCompValue;
            }

            if (Enum.TryParse(missionCapableSelectedIndex.ToString(), out TrueOrFalse missCapValue))
            {
                Item.MissionCapable = missCapValue;
            }

            if (Enum.TryParse(checkedOutSelectedIndex.ToString(), out TrueOrFalse checkOutValue))
            {
                Item.CheckedOut = checkOutValue;
            }
        }

        private async void RefreshDetails()
        {
            var item = await repository.GetItemByIdAsync(Item.Id.ToString());
            var defString = string.Empty;
            Defects = string.Empty;
            if (item.Defects != null)
            {
                for (int i = 0; i < item.Defects.Count; i++)
                {
                    defString += item.Defects[i].Trim();

                    if (i < item.Defects.Count - 1) defString += ", ";
                }  
                Defects = defString;
            }

            var missString = string.Empty;
            MissingComponents = string.Empty;
            if (item.MissingComponents != null)
            {
                for (int i = 0; i < item.MissingComponents.Count; i++)
                {
                    missString += item.MissingComponents[i].Trim();

                    if (i < item.MissingComponents.Count - 1) missString += ", ";
                }
                MissingComponents = missString;
            }
        }

        //Commands

        [RelayCommand]
        public async Task GoToMainPageAsync()
        {
            await Shell.Current.GoToAsync($"/{nameof(MainPage)}");
        }

        [RelayCommand]
        public async Task AddItem()
        {
            Item.Id = Guid.NewGuid();
            SetItemPropsWithPickers();

            await repository.AddItemAsync(item);
            await Shell.Current.GoToAsync($"/{nameof(MainPage)}");
        }

        [RelayCommand]
        public async Task UpdateItem()
        {
            Item.MissingComponents = MissingComponents.Split(",").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            Item.Defects = Defects.Split(",").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            await repository.UpdateItemAsync(item.Id, item);;
        }

        [RelayCommand]
        public void RefreshItemDetails()
        {
            RefreshDetails(); 
        }
    }
}
