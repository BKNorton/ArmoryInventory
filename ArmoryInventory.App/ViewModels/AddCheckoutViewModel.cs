using ArmoryInventory.App.Views;
using ArmoryInventory.App.Views.Popups;
using ArmoryInventory.Data.Interfaces;
using ArmoryInventory.Domain.Models;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventory.App.ViewModels
{
    public partial class AddCheckoutViewModel : ObservableObject
    {
        private readonly IRepository repository;
        private readonly IPopupService popupService;
        public ObservableCollection<string> ItemDefectsCollection { get; set; }
        public ObservableCollection<string> ItemMissingComponentsCollection { get; set; }

        private Item item;
        public Item Item
        {
            get => item;
            set
            {
                SetProperty(ref item, value);
            }
        }

        private string selectedDefect;
        public string SelectedDefect
        {
            get => selectedDefect;
            set
            {
                SetProperty(ref selectedDefect, value);
            }
        }

        private string selectedMissingComp;
        public string SelectedMissingComp
        {
            get => selectedDefect;
            set
            {
                SetProperty(ref selectedMissingComp, value);
            }
        }

        private string checkoutTo;
        public string CheckoutTo
        {
            get => checkoutTo;
            set
            {
                SetProperty(ref checkoutTo, value);
            }
        }

        private string checkoutReason;
        public string CheckoutReason
        {
            get => checkoutReason;
            set
            {
                SetProperty(ref checkoutReason, value);
            }
        }

        public AddCheckoutViewModel(IRepository repository, IPopupService popupService)
        {
            this.repository = repository;
            this.popupService = popupService;
            item = new Item();
            selectedDefect = string.Empty;
            selectedMissingComp = string.Empty;
            checkoutTo = string.Empty;
            checkoutReason = string.Empty;
            ItemDefectsCollection = [];
            ItemMissingComponentsCollection = [];
        }

        public async Task LoadPageAsync(string itemId)
        {
            //Verification
            if (Item.SerialNumber != null) Item = new Item(); //Reset Item if it already has a value
            if (string.IsNullOrWhiteSpace(itemId)) return;
            Item = await repository.GetItemByIdAsync(itemId);
            if (Item is null || Item.Id == Guid.Empty) return;

            

            //Load properties
            var itemDefects = Item.Defects;
            if (itemDefects != null && itemDefects.Count > 0)
            {
                ItemDefectsCollection.Clear();
                for (int i = 0; i < itemDefects.Count; i++)
                {
                    ItemDefectsCollection.Add(itemDefects[i].Trim());
                }
            }

            var itemMissingComponents = Item.MissingComponents;
            if (itemMissingComponents != null && itemMissingComponents.Count > 0)
            {
                ItemMissingComponentsCollection.Clear();
                for (int i = 0; i < itemMissingComponents.Count; i++)
                {
                    ItemMissingComponentsCollection.Add(itemMissingComponents[i].Trim());
                }
            }
        }

        public void ReFreshItemsAsync()
        {
            ItemDefectsCollection.Clear();
            ItemMissingComponentsCollection.Clear();
        }

        [RelayCommand]
        public async Task GoToMainPageAsync()
        {
            await Shell.Current.GoToAsync($"/{nameof(MainPage)}");
        }


        [RelayCommand]
        public async Task RemoveDefect()
        {
            if (selectedDefect == string.Empty) return;
            ItemDefectsCollection.Remove(selectedDefect);
            var defects = ItemDefectsCollection.ToList();
            item.Defects = defects;
            await repository.UpdateItemAsync(item.Id, item);
        }

        [RelayCommand]
        public async Task RemoveMissComponent()
        {
            if (selectedDefect == string.Empty) return;
            ItemMissingComponentsCollection.Remove(selectedMissingComp);
            var missingComp = ItemMissingComponentsCollection.ToList();
            item.MissingComponents = missingComp;
            await repository.UpdateItemAsync(item.Id, item);
        }

        [RelayCommand]
        public async Task AddDefect()
        {
            var obj = await this.popupService.ShowPopupAsync<AddDefectPopupViewModel>(onPresenting: viewModel => viewModel.Item = this.item);
            SelectedDefect = string.Empty;
            await LoadPageAsync(Item.Id.ToString());
        }
    }
}
