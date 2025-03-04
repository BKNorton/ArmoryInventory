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
    public partial class AddDefectPopupViewModel : ObservableObject 
    {
        private readonly IRepository repository;
        private readonly IPopupService popupService;

        public Item Item;

        private string defect;
        public string Defect
        {
            get => defect;
            set
            {
                SetProperty(ref defect, value);
            }
        }

        public AddDefectPopupViewModel(IRepository repository, IPopupService popupService)
        {
            Item = new Item();
            defect = string.Empty;
            this.repository = repository;
            this.popupService = popupService;
        }

        [RelayCommand]
        public async Task ClosePopup()
        {
            await popupService.ClosePopupAsync();
        }

        [RelayCommand]
        public async Task AddDefect()
        {
            Item.Defects.Add(defect);
            await repository.UpdateItemAsync(Item.Id, Item);
            await popupService.ClosePopupAsync();
        }
    }
}
