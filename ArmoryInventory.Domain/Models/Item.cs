﻿using ArmoryInventory.Domain.Enums;
using Type = ArmoryInventory.Domain.Enums.Type;

namespace ArmoryInventory.Domain.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string? SerialNumber { get; set; }
        public Type ItemType { get; set; }
        public TrueOrFalse HasAllComponents { get; set; }
        public TrueOrFalse MissionCapable { get; set; }
        public TrueOrFalse CheckedOut { get; set; }
        public List<string>? Defects { get; set; }
        public List<string>? MissingComponents { get; set; }
        public List<Checkout>? CheckoutHistory { get; set; }
    }
}
