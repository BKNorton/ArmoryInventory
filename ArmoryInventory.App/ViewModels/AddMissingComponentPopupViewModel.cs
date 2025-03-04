using ArmoryInventory.Data.Interfaces;
using ArmoryInventory.Domain.Models;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventory.App.ViewModels
{
    public partial class AddMissingComponentPopupViewModel : ObservableObject
    {
        private readonly IRepository repository;
        private readonly IPopupService popupService;

        public Item Item;

        private string missingComp;
        public string MissingComp
        {
            get => missingComp;
            set
            {
                SetProperty(ref missingComp, value);
            }
        }

        public AddMissingComponentPopupViewModel(IRepository repository, IPopupService popupService)
        {
            Item = new Item();
            missingComp = string.Empty;
            this.repository = repository;
            this.popupService = popupService;
        }

        [RelayCommand]
        public async Task ClosePopup()
        {
            await popupService.ClosePopupAsync();
        }

        [RelayCommand]
        public async Task AddMissingComp()
        {
            if (Item.MissingComponents is null) Item.MissingComponents = [];
            Item.MissingComponents.Add(missingComp);
            await repository.UpdateItemAsync(Item.Id, Item);
            await popupService.ClosePopupAsync();
        }
    }
}
