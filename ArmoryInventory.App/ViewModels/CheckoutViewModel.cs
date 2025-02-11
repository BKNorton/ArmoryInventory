using ArmoryInventory.Data.Interfaces;
using ArmoryInventory.Domain.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventory.App.ViewModels
{
    public partial class CheckoutViewModel : ObservableObject 
    {
        private readonly IRepository repository;

        private Item item;
        public Item Item
        {
            get => item;
            set
            {
                SetProperty(ref item, value);
            }
        }

        public CheckoutViewModel(IRepository repository)
        {
            this.repository = repository;
        }
    }
}
