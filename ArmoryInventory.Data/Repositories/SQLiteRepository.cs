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

        //Item Functions

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

        /// <summary>
        /// This includes Item CheckoutHistory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Item> GetItemWithCheckoutsByIdAsync(string id)
        {
            var item = _context.Items.Where(x => x.Id.ToString().ToLower() == id).Include(i => i.CheckoutHistory).FirstOrDefault();
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
            var itemsList = await _context.Items.ToListAsync();
            if (string.IsNullOrWhiteSpace(filterText))
            {
                
                if (itemsList == null)
                    return new List<Item>();
                else return itemsList;
            }

            var items = itemsList.Where(x => !string.IsNullOrWhiteSpace(x.SerialNumber)
                && x.SerialNumber.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)).ToList();

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

            //var itemToUpdate = await _context.Items.FirstOrDefaultAsync(x => x.Id == Id);
            //if (itemToUpdate != null)
            //{
            //    itemToUpdate.Defects = item.Defects;
            //    itemToUpdate.HasAllComponents = item.HasAllComponents;
            //    itemToUpdate.MissingComponents = item.MissingComponents;
            //    itemToUpdate.CheckedOut = item.CheckedOut;
            //    _context.Items.Update(itemToUpdate);
            //    _context.SaveChanges();
            //}

            _context.Items.Update(item);
            await _context.SaveChangesAsync();
            
            return Task.CompletedTask;
        }

        //Checkout Functions
        public async Task<Task> AddCheckoutAsync(Checkout checkout)
        {
            await _context.Checkouts.AddAsync(checkout);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
