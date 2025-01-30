using ArmoryInventory.Data.Interfaces;
using ArmoryInventory.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ArmoryInventory.Data.Repositories
{
    public class SQLiteRepository : IRepository
    {
        protected readonly ArmoryInventoryDbContext _context;

        public SQLiteRepository(ArmoryInventoryDbContext context) 
        {
            _context = context;
        }

        public async Task<Task> AddItemAsync(Item item)
        {
            await _context.Items.AddAsync(item);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task<Item> GetItemByIdAsync(string id)
        {
            var item = _context.Items.Where(x => x.Id.ToString().ToLower() == id).FirstOrDefault();
                  if (item != null)
                  {
                      return Task.FromResult(item);
                  }
                  item = new Item();
                   return Task.FromResult(item);
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            var items = await _context.Items.ToListAsync();
            return items;
        }

        public async Task<List<Item>> GetItemsByFiltersAsync(int typeIndex, int hasCompIndex, int missCapIndex, int checkOutIndex)
        {
            if (typeIndex != 0)
            {
                var items = await _context.Items.Where(x => (int)x.ItemType == typeIndex).ToListAsync();
                if (hasCompIndex != 0) items = items.Where(x => (int)x.HasAllComponents == hasCompIndex).ToList();
                if (missCapIndex != 0) items = items.Where(x => (int)x.MissionCapable == missCapIndex).ToList();
                if (checkOutIndex != 0) items = items.Where(x => (int)x.CheckedOut == checkOutIndex).ToList();
                return items;
            }
            else if (hasCompIndex != 0)
            {
                var items = await _context.Items.Where(x => (int)x.HasAllComponents == hasCompIndex).ToListAsync();
                if (missCapIndex != 0) items = items.Where(x => (int)x.MissionCapable == missCapIndex).ToList();
                if (checkOutIndex != 0) items = items.Where(x => (int)x.CheckedOut == checkOutIndex).ToList();
                return items;
            }
            else if (missCapIndex != 0)
            {
                var items = await _context.Items.Where(x => (int)x.MissionCapable == missCapIndex).ToListAsync();
                if (checkOutIndex != 0) items = items.Where(x => (int)x.CheckedOut == checkOutIndex).ToList();
                return items;
            }
            else if (checkOutIndex != 0)
            {
                var items = _context.Items.Where(x => (int)x.CheckedOut == checkOutIndex).ToList();
                return items;
            }
            else return await _context.Items.ToListAsync();
        }

        public async Task<List<Item>> GetItemsBySearchAsync(string filterText)
        {
            if (string.IsNullOrWhiteSpace(filterText))
            {
                var itemsList = await _context.Items.ToListAsync();
                if (itemsList == null)
                    return new List<Item>();
                else return itemsList;
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var items = await _context.Items.Where(x => !string.IsNullOrWhiteSpace(x.SerialNumber)
                && x.SerialNumber.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToListAsync();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            if (items is null || items.Count <= 0)
            {
                return new List<Item>();
            }

            return items;
        }

        public Task RemoveItem(Item item)
        {
            _context.Items.Remove(item);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<Task> UpdateItemAsync(Guid Id, Item item)
        {
            if (Id != item.Id) return Task.CompletedTask;

            var itemToUpdate = await _context.Items.FirstOrDefaultAsync(x => x.Id == Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.SerialNumber = item.SerialNumber;
                itemToUpdate.ItemType = item.ItemType;
                itemToUpdate.Defects = item.Defects;
                itemToUpdate.HasAllComponents = item.HasAllComponents;
                itemToUpdate.MissingComponents = item.MissingComponents;
                itemToUpdate.CheckedOut = item.CheckedOut;
            }

            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
